using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using website.Models;
using System.Threading.Tasks;
using System.Linq;

namespace website.Controllers
{
    [Authorize(Roles = "Admin")]
    public class AdminController : Controller
    {
        private readonly WebDbContext _db;

        public AdminController(WebDbContext db)
        {
            _db = db;
        }

        // =======================
        // ADMIN DASHBOARD
        // =======================
        public async Task<IActionResult> AdminDashboard()
        {
            // Name from CLAIM (best practice)
            var firstName = User.FindFirst("FirstName")?.Value ?? "Admin";
            ViewBag.Message = $"Welcome, {firstName}!";

            var banners = await _db.Banners
                                   .Where(b => b.Page == "Admin")
                                   .ToListAsync();

            return View(banners);
        }

        // =======================
        // ADMIN PROFILE
        // =======================
        public IActionResult EditProfile()
        {
            return View();
        }

// ---------- Users ----------
public async Task<IActionResult> Users()
        {
            return View(await _db.Users.ToListAsync());
        }

        public async Task<IActionResult> EditUser(int? id)
        {
            if (id == null) return NotFound();
            var user = await _db.Users.FindAsync(id);
            if (user == null) return NotFound();
            return View(user);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditUser(Users user) 
        {
            if (!ModelState.IsValid) return View(user);

            _db.Users.Update(user);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Users));
        }

        public async Task<IActionResult> DeleteUser(int? id)
        {
            if (id == null) return NotFound();
            var user = await _db.Users.FindAsync(id);
            if (user != null)
            {
                _db.Users.Remove(user);
                await _db.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Users));
        }

        // ---------- Categories ----------
        public async Task<IActionResult> Categories()
        {
            return View(await _db.Categories.ToListAsync());
        }

        public async Task<IActionResult> EditCategory(int? id)
        {
            if (id == null) return NotFound();
            var category = await _db.Categories.FindAsync(id);
            if (category == null) return NotFound();
            return View(category);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditCategory(Category category)
        {
            if (!ModelState.IsValid) return View(category);

            _db.Categories.Update(category);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Categories));
        }

        public async Task<IActionResult> DeleteCategory(int? id)
        {
            if (id == null) return NotFound();
            var category = await _db.Categories.FindAsync(id);
            if (category != null)
            {
                _db.Categories.Remove(category);
                await _db.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Categories));
        }

        // ---------- Products ----------
        public async Task<IActionResult> Products()
        {
            var products = await _db.Products
                                    .AsNoTracking()       // ✅ tracking off -> fast
                                    .Include(p => p.Category)
                                    .OrderByDescending(p => p.Id) // ✅ latest first
                                    .Take(100)           // ✅ limit records
                                    .ToListAsync();

            return View(products);
        }


        // ---------- Add Product (GET) ----------
        public async Task<IActionResult> AddProduct()
        {
            ViewBag.Categories = await _db.Categories.ToListAsync();
            return View();
        }

        // ---------- Add Product (POST) ----------
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = await _db.Categories.ToListAsync();
                return View(product);
            }

            _db.Products.Add(product);
            await _db.SaveChangesAsync();
            TempData["Success"] = "Product added successfully!";
            return RedirectToAction(nameof(Products));
        }

        // ---------- Edit Product (GET) ----------
        public async Task<IActionResult> EditProduct(int? id)
        {
            if (id == null) return NotFound();

            var product = await _db.Products
                                   .Include(p => p.Category)
                                   .FirstOrDefaultAsync(p => p.Id == id);

            if (product == null) return NotFound();

            ViewBag.Categories = await _db.Categories.ToListAsync();
            return View(product);
        }

        // ---------- Edit Product (POST) ----------
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = await _db.Categories.ToListAsync();
                return View(product);
            }

            var existingProduct = await _db.Products.FindAsync(product.Id);
            if (existingProduct == null) return NotFound();

            // Update fields
            existingProduct.Name = product.Name;
            existingProduct.Price = product.Price;
            existingProduct.CategoryId = product.CategoryId;
            existingProduct.Description = product.Description;
            existingProduct.ImageUrl = product.ImageUrl;

            _db.Products.Update(existingProduct);
            await _db.SaveChangesAsync();

            TempData["Success"] = "Product updated successfully!";
            return RedirectToAction(nameof(Products));
        }

        // ---------- Delete Product ----------
        public async Task<IActionResult> DeleteProduct(int? id)
        {
            if (id == null) return NotFound();

            var product = await _db.Products.FindAsync(id);
            if (product == null) return NotFound();

            _db.Products.Remove(product);
            await _db.SaveChangesAsync();

            TempData["Success"] = "Product deleted successfully!";
            return RedirectToAction(nameof(Products));
        }

        // ---------- Carts ----------
        public async Task<IActionResult> Carts()
        {
            var carts = await _db.Carts.Include(c => c.User)
                                       .Include(c => c.Product)
                                       .ToListAsync();
            return View(carts);
        }

        public async Task<IActionResult> DeleteCart(int? id)
        {
            if (id == null) return NotFound();
            var cart = await _db.Carts.FindAsync(id);
            if (cart != null)
            {
                _db.Carts.Remove(cart);
                await _db.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Carts));
        }

        // ---------- Orders ----------
        public async Task<IActionResult> Orders()
        {
            var orders = await _db.Orders
                                 .Include(o => o.User)
                                 .Include(o => o.Product)
                                 .ToListAsync();

            return View(orders);
        }

        // =======================
        // UPDATE STATUS
        // =======================
        [HttpPost]
        public async Task<IActionResult> UpdateStatus(int id, string status)
        {
            var order = await _db.Orders.FindAsync(id);

            if (order == null)
                return NotFound();

            order.Status = status;
            await _db.SaveChangesAsync();

            return RedirectToAction(nameof(Orders));
        }

        // =======================
        // DELETE ORDER
        // =======================
        public async Task<IActionResult> DeleteOrder(int id)
        {
            var order = await _db.Orders.FindAsync(id);

            if (order != null)
            {
                _db.Orders.Remove(order);
                await _db.SaveChangesAsync();
            }

            return RedirectToAction(nameof(Orders));
        }




        // ---------- Banners ----------
        public async Task<IActionResult> Banners()
        {
            return View(await _db.Banners.ToListAsync());
        }

        // Add Banner - GET
        public IActionResult AddBanner() => View();

        // Add Banner - POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddBanner(Banner banner)
        {
            if (!ModelState.IsValid) return View(banner);

            _db.Banners.Add(banner);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Banners));
        }

        // Edit Banner
        public async Task<IActionResult> EditBanner(int? id)
        {
            if (id == null) return NotFound();
            var banner = await _db.Banners.FindAsync(id);
            if (banner == null) return NotFound();
            return View(banner);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditBanner(Banner banner)
        {
            if (!ModelState.IsValid) return View(banner);

            _db.Banners.Update(banner);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Banners));
        }

        // Delete Banner
        public async Task<IActionResult> DeleteBanner(int? id)
        {
            if (id == null) return NotFound();
            var banner = await _db.Banners.FindAsync(id);
            if (banner != null)
            {
                _db.Banners.Remove(banner);
                await _db.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Banners));
        }

        // ===========================
        // SLIDERS CRUD
        // ===========================

        public async Task<IActionResult> Sliders()
        {
            return View(await _db.Sliders.ToListAsync());
        }

        // Add Slider - GET
        public IActionResult AddSlider() => View();

        // Add Slider - POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddSlider(Slider slider)
        {
            if (!ModelState.IsValid) return View(slider);

            _db.Sliders.Add(slider);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Sliders));
        }

        // Edit Slider
        public async Task<IActionResult> EditSlider(int? id)
        {
            if (id == null) return NotFound();
            var slider = await _db.Sliders.FindAsync(id);
            if (slider == null) return NotFound();
            return View(slider);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditSlider(Slider slider)
        {
            if (!ModelState.IsValid) return View(slider);

            _db.Sliders.Update(slider);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Sliders));
        }

        // Delete Slider
        public async Task<IActionResult> DeleteSlider(int? id)
        {
            if (id == null) return NotFound();
            var slider = await _db.Sliders.FindAsync(id);
            if (slider != null)
            {
                _db.Sliders.Remove(slider);
                await _db.SaveChangesAsync();
            }
            return RedirectToAction(nameof(Sliders));
        }


        // ===========================
        // PAGE CONTENTS CRUD
        // ===========================

        public async Task<IActionResult> PageContents()
        {
            var pages = await _db.PageContents.ToListAsync();
            return View(pages);
        }

        // Add Page - GET
        public IActionResult AddPage() => View();

        // Add Page - POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> AddPage(PageContent page)
        {
            if (!ModelState.IsValid) return View(page);

            _db.PageContents.Add(page);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(PageContents));
        }

        // Edit Page - GET
        public async Task<IActionResult> EditPage(int? id)
        {
            if (id == null) return NotFound();
            var page = await _db.PageContents.FindAsync(id);
            if (page == null) return NotFound();
            return View(page);
        }

        // Edit Page - POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> EditPage(PageContent page)
        {
            if (!ModelState.IsValid) return View(page);

            _db.PageContents.Update(page);
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(PageContents));
        }

        // Delete Page
        public async Task<IActionResult> DeletePage(int? id)
        {
            if (id == null) return NotFound();
            var page = await _db.PageContents.FindAsync(id);
            if (page != null)
            {
                _db.PageContents.Remove(page);
                await _db.SaveChangesAsync();
            }
            return RedirectToAction(nameof(PageContents));
        }

        public IActionResult Reviews()
        {
            var reviews = _db.Reviews.OrderByDescending(r => r.CreatedAt).ToList();
            return View(reviews);
        }
        public IActionResult ContactMessages()
        {
            var messages = _db.ContactMessages
                              .OrderByDescending(m => m.CreatedAt)
                              .ToList();
            return View(messages);
        }
    }
}