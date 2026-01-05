using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;   // ✅
using Microsoft.AspNetCore.Http;      // ✅
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.IO;
using System.Security.Claims;
using website.Models;

namespace website.Controllers
{
    public class FormController : Controller
    {
        private readonly WebDbContext _Db;
        private readonly IWebHostEnvironment _env; // ✅

        // ✅ FIXED CONSTRUCTOR
        public FormController(WebDbContext db, IWebHostEnvironment env)
        {
            _Db = db;
            _env = env;     // ✅ NOW VALID
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Subscribe(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return BadRequest("Email is required");

            await _Db.Newsletters.AddAsync(new Newsletter { Email = email.Trim() });
            await _Db.SaveChangesAsync();

            return Json(new { success = true, message = "Subscribed successfully!" });
        }





        public IActionResult SearchProducts(string query)
        {
            if (string.IsNullOrWhiteSpace(query))
                return RedirectToAction("Index");

            // Category name match (case-insensitive)
            var category = _Db.Categories
                .FirstOrDefault(c => c.Name.ToLower().Contains(query.ToLower()));

            if (category != null)
            {
                // Redirect to products page of that category
                return RedirectToAction("Products", new { categoryId = category.Id });
            }

            // No category found → show empty results page (optional)
            TempData["Error"] = "No matching category found!";
            return RedirectToAction("Index");
        }


        // ======================
        // HOME PAGE
        // ======================



        public async Task<IActionResult> Index()
        {
            var model = new ViewModel
            {
                Categories = await _Db.Categories.ToListAsync(),
                Sliders = await _Db.Sliders.ToListAsync(),
                TrendingProducts = await _Db.Products.Where(p => p.IsTrending).ToListAsync(),
                NewAdditions = await _Db.NewAdditions.ToListAsync(),
                Pages = await _Db.PageContents.ToListAsync()
            };

            return View(model);
        }


        // ✅ PAGE 1 – SHOW ONLY NEW ADDITIONS
        public async Task<IActionResult> NewAdditions()
        {
            var newAdditions = await _Db.NewAdditions
                                        .ToListAsync();

            return View(newAdditions);
        }





        // ======================
        // VIEW PAGE (About, Contact etc.)
        // ======================
        public async Task<IActionResult> ViewPage(int id)
        {
            var page = await _Db.PageContents.FindAsync(id);
            if (page == null) return NotFound();
            return View(page);
        }

        // ======================
        // SUBMIT REVIEW
        // ======================
        [HttpPost]
        public async Task<IActionResult> SubmitReview(string Name, int Rating, string Message)
        {
            var review = new Review
            {
                Name = Name,
                Rating = Rating,
                Message = Message,
                CreatedAt = DateTime.Now
            };

            await _Db.Reviews.AddAsync(review);
            await _Db.SaveChangesAsync();

            TempData["ReviewSuccess"] = "Thank you! Your review has been submitted ✅";
            return RedirectToAction("ViewPage", new { id = 5 });
        }


        // ======================
        // CONTACT FORM
        // ======================
        [HttpPost]
        public async Task<IActionResult> Contact(string Name, string Email, string Subject, string Message)
        {
            var msg = new ContactMessage
            {
                Name = Name,
                Email = Email,
                Subject = Subject,
                Message = Message,
                CreatedAt = DateTime.Now
            };

            await _Db.ContactMessages.AddAsync(msg);
            await _Db.SaveChangesAsync();

            TempData["ContactSuccess"] = "Message sent successfully ✅";
            return RedirectToAction("ViewPage", new { id = 2 });
        }



        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        // ================= STEP-1 POST =================
        // STEP-1 REGISTER (OK)
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(Users model)
        {
            ModelState.Remove("Password");
            ModelState.Remove("ConfirmPassword");
            ModelState.Remove("PostalAddress");

            if (!ModelState.IsValid)
                return View(model);
            model.Role = "User";

            model.Email = model.Email.Trim();

            if (await _Db.Users.AnyAsync(u => u.Email == model.Email))
            {
                ModelState.AddModelError("Email", "User already registered with this email.");
                return View(model);
            }

            _Db.Users.Add(model);
            await _Db.SaveChangesAsync();

            return RedirectToAction("MoreInfo", new { id = model.Id });
        }

        // ================= STEP-2 GET =================
        [HttpGet]
        public IActionResult MoreInfo(int id)
        {
            var user = _Db.Users.Find(id);
            if (user == null) return NotFound();

            return View(user);
        }

        // ================= STEP-2 POST =================







        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> SaveMoreInfo(Users model, IFormFile ProfileImage)
        {
            var user = await _Db.Users.FindAsync(model.Id);
            if (user == null) return NotFound();

            // Ignore Step-1 fields
            ModelState.Remove("FirstName");
            ModelState.Remove("LastName");
            ModelState.Remove("Age");
            ModelState.Remove("DateOfBirth");
            ModelState.Remove("Gender");
            ModelState.Remove("Email");
            ModelState.Remove("Role");

            if (!ModelState.IsValid)
                return View("MoreInfo", user);

            // Save postal address
            user.PostalAddress = model.PostalAddress;

            // Save password if provided
            if (!string.IsNullOrWhiteSpace(model.Password))
            {
                var hasher = new PasswordHasher<Users>();
                user.Password = hasher.HashPassword(user, model.Password);
            }

            // Save profile image
            if (ProfileImage != null && ProfileImage.Length > 0)
            {
                string folder = Path.Combine(_env.WebRootPath, "images");
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);

                string fileName = Guid.NewGuid() + Path.GetExtension(ProfileImage.FileName);
                string path = Path.Combine(folder, fileName);

                using (var stream = new FileStream(path, FileMode.Create))
                {
                    await ProfileImage.CopyToAsync(stream);
                }

                user.ProfileImage = "/images/" + fileName;
            }

            await _Db.SaveChangesAsync();

            return RedirectToAction("Index", "Form");
        }





        // ======================
        // LOGIN (GET)
        // ======================
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }



        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                ViewBag.LoginError = "Please enter email and password.";
                return View();
            }

            var user = await _Db.Users.FirstOrDefaultAsync(u => u.Email == email.Trim());
            if (user == null)
            {
                ViewBag.LoginError = "Invalid Email or Password";
                return View();
            }

            var hasher = new PasswordHasher<Users>();
            var result = hasher.VerifyHashedPassword(user, user.Password, password);

            if (result == PasswordVerificationResult.Failed)
            {
                ViewBag.LoginError = "Invalid Email or Password";
                return View();
            }

            // Create claims
            var claims = new List<Claim>
    {
        new Claim(ClaimTypes.Name, user.Email),
        new Claim("FirstName", user.FirstName),
        new Claim(ClaimTypes.Role, user.Role)
    };

            var identity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var principal = new ClaimsPrincipal(identity);

            await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

            // ✅ Role-based redirect
            if (user.Role == "Admin")
                return RedirectToAction("AdminDashboard", "Admin");

            return RedirectToAction("Index", "Form");
        }


        // ======================
        // LOGOUT
        // ======================
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Form");
        }



        private int GetUserId()
        {
            // Get the logged-in user's email from claims
            var email = User?.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Name)?.Value;
            if (string.IsNullOrEmpty(email))
                throw new Exception("User is not logged in.");

            var user = _Db.Users.FirstOrDefault(u => u.Email == email);
            if (user == null)
                throw new Exception("User not found.");

            return user.Id;
        }

        // ======================
        // PRODUCTS LIST (CATEGORY OR NEWADDITION BASED)
        // ======================
        public IActionResult Products(int? categoryId, int? newAdditionId)
        {
            IQueryable<Product> query = _Db.Products;

            Category? category = null;
            string? newAdditionTitle = null;

            // Category filter
            if (categoryId.HasValue)
            {
                query = query.Where(p => p.CategoryId == categoryId.Value);
                category = _Db.Categories.FirstOrDefault(c => c.Id == categoryId.Value);
            }

            // NewAddition filter
            if (newAdditionId.HasValue)
            {
                query = query.Where(p => p.NewAdditionId == newAdditionId.Value);
                newAdditionTitle = _Db.NewAdditions
                                        .Where(n => n.Id == newAdditionId.Value)
                                        .Select(n => n.Title)
                                        .FirstOrDefault();
            }

            ViewBag.Category = category;                   // Category info (banner, description)
            ViewBag.NewAdditionTitle = newAdditionTitle;   // NewAddition title

            return View(query.ToList());                   // Send products to view
        }



        // ======================
        // PRODUCT DETAILS
        // ======================
        public async Task<IActionResult> ProductDetails(int id)
        {
            var product = await _Db.Products.FirstOrDefaultAsync(p => p.Id == id);
            if (product == null) return NotFound();

            // Pass the color to the footer
            ViewBag.ProductColor = product.Color;  // <-- Here
            return View(product);
        }

        // ======================
        // ADD TO CART
        // ======================
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> AddToCart(int productId, int quantity = 1)
        {
            var email = User.Identity?.Name;
            if (string.IsNullOrEmpty(email))
                return Json(new { success = false, message = "Please login first." });

            var user = await _Db.Users.FirstOrDefaultAsync(u => u.Email == email);
            if (user == null)
                return Json(new { success = false, message = "User not found." });

            var cartItem = await _Db.Carts.FirstOrDefaultAsync(c => c.UserId == user.Id && c.ProductId == productId);
            if (cartItem != null)
                cartItem.Quantity += quantity;
            else
                await _Db.Carts.AddAsync(new Cart { UserId = user.Id, ProductId = productId, Quantity = quantity, AddedAt = DateTime.Now });

            await _Db.SaveChangesAsync();

            int cartCount = await _Db.Carts.Where(c => c.UserId == user.Id).SumAsync(c => c.Quantity);

            return Json(new { success = true, message = "Product added to cart!", cartCount = cartCount });
        }



        [Authorize]
        public async Task<IActionResult> Cart()
        {
            var user = await _Db.Users.FirstOrDefaultAsync(u => u.Email == User.Identity.Name);
            if (user == null)
                return RedirectToAction("Login");

            var cartItems = await _Db.Carts
                                     .Include(c => c.Product)
                                     .Where(c => c.UserId == user.Id)
                                     .ToListAsync();

            return View(cartItems);
        }



        // ======================
        // UPDATE CART
        // ======================
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> UpdateCart(int cartId, string action, int quantity = 1)
        {
            var userId = GetUserId();
            var item = await _Db.Carts.FirstOrDefaultAsync(c => c.Id == cartId && c.UserId == userId);

            if (item == null) return RedirectToAction("Cart");

            switch (action)
            {
                case "increase":
                    item.Quantity++;
                    break;
                case "decrease":
                    if (item.Quantity > 1) item.Quantity--;
                    break;
                case "remove":
                    _Db.Carts.Remove(item);
                    break;
                case "update":
                    if (quantity > 0) item.Quantity = quantity;
                    break;
            }

            await _Db.SaveChangesAsync();
            return RedirectToAction("Cart");
        }
        // ======================
        // BUY NOW
        // ======================
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> BuyNow(int productId, int quantity = 1)
        {
            var userId = GetUserId();
            var product = await _Db.Products.FindAsync(productId);
            if (product == null) return NotFound();

            var cartItem = await _Db.Carts.FirstOrDefaultAsync(c => c.UserId == userId && c.ProductId == productId);
            if (cartItem != null)
                cartItem.Quantity += quantity;
            else
                await _Db.Carts.AddAsync(new Cart
                {
                    UserId = userId,
                    ProductId = productId,
                    Quantity = quantity,
                    AddedAt = DateTime.Now
                });

            await _Db.SaveChangesAsync();
            return RedirectToAction("Checkout");
        }

        private Users GetLoggedInUser()
        {
            // Logged-in user ka email claim
            var email = User.Identity?.Name;
            if (string.IsNullOrEmpty(email))
                return null;

            // Database se user fetch karo
            var user = _Db.Users.FirstOrDefault(u => u.Email == email);
            return user;
        }



        [Authorize]
        public async Task<IActionResult> Checkout()
        {
            // Logged-in user fetch karo
            var user = GetLoggedInUser();
            if (user == null)
                return RedirectToAction("Login");

            // User ka cart fetch karo
            var cartItems = await _Db.Carts
                                     .Include(c => c.Product)
                                     .Where(c => c.UserId == user.Id)
                                     .ToListAsync();

            // Auto-fill user info
            ViewBag.UserFirstName = user.FirstName;
            ViewBag.UserLastName = user.LastName;
            ViewBag.UserEmail = user.Email;
            ViewBag.UserAddress = user.PostalAddress;

            return View(cartItems);
        }


        // ======================
        // PLACE ORDER
        // ======================
        [Authorize]
        [HttpPost]
        public async Task<IActionResult> PlaceOrder(string FullName, string Email, string Address, string PaymentMethod)
        {
            var userId = GetUserId();
            var cartItems = await _Db.Carts.Include(c => c.Product).Where(c => c.UserId == userId).ToListAsync();

            if (!cartItems.Any())
            {
                TempData["Error"] = "Cart is empty!";
                return RedirectToAction("Cart");
            }

            foreach (var item in cartItems)
            {
                await _Db.Orders.AddAsync(new Order
                {
                    UserId = userId,
                    ProductId = item.ProductId,
                    Quantity = item.Quantity,
                    TotalPrice = item.Quantity * item.Product.Price,
                    OrderDate = DateTime.Now,
                    Status = "Pending"
                });
            }

            _Db.Carts.RemoveRange(cartItems);
            await _Db.SaveChangesAsync();

            return RedirectToAction("OrderSuccess");
        }

        // ======================
        // ORDER SUCCESS
        // ======================
        [Authorize]
        public IActionResult OrderSuccess() => View();







        [Authorize(Roles = "User,Admin")]
        [HttpGet]
        public IActionResult Profile()
        {
            var email = User.Identity.Name; // ✅ use claims
            if (string.IsNullOrEmpty(email))
                return RedirectToAction("Login", "Form");

            var user = _Db.Users.FirstOrDefault(u => u.Email == email);
            if (user == null)
                return RedirectToAction("Login", "Form");

            return View(user);
        }

        [Authorize(Roles = "User,Admin")]
        [HttpPost]
        public IActionResult Profile(Users model)
        {
            var email = User.Identity.Name; // ✅ use claims
            if (string.IsNullOrEmpty(email))
                return RedirectToAction("Login", "Form");

            var user = _Db.Users.FirstOrDefault(u => u.Email == email);
            if (user == null)
                return RedirectToAction("Login", "Form");

            if (_Db.Users.Any(u => u.Email == model.Email && u.Id != user.Id))
            {
                ModelState.AddModelError("Email", "Email already taken by another user");
                return View(model);
            }

            // Update info
            user.FirstName = model.FirstName;
            user.LastName = model.LastName;
            user.Age = model.Age;
            user.DateOfBirth = model.DateOfBirth;
            user.Gender = model.Gender;
            user.Email = model.Email;
            user.PostalAddress = model.PostalAddress;

            if (!string.IsNullOrEmpty(model.Password))
                user.Password = model.Password; // ideally hash

            _Db.SaveChanges();

            ViewBag.Message = "Profile updated successfully!";
            return View(user);
        }

        [Authorize(Roles = "User,Admin")]
        public IActionResult Orders()
        {
            var email = User.Identity.Name;
            if (string.IsNullOrEmpty(email))
                return RedirectToAction("Login", "Form");

            var user = _Db.Users.FirstOrDefault(u => u.Email == email);
            if (user == null)
                return RedirectToAction("Login", "Form");

            var orders = _Db.Orders
                .Include(o => o.Product)          // ✅ Important
                .Where(o => o.UserId == user.Id)
                .OrderByDescending(o => o.OrderDate)
                .ToList();

            return View(orders);
        }


    }
}
