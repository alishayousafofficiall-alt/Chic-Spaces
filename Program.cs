using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using website.Models;

var builder = WebApplication.CreateBuilder(args);

// ======================
// Add services
// ======================
builder.Services.AddControllersWithViews();

// Database
builder.Services.AddDbContext<WebDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

// Cookie Authentication
builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
    .AddCookie(options =>
    {
        options.LoginPath = "/Form/Login";           // Redirect when not logged in
        options.AccessDeniedPath = "/Form/Login";    // Redirect on access denied
        options.ExpireTimeSpan = TimeSpan.FromHours(1);
    });

// Authorization
builder.Services.AddAuthorization();

// Session & Cache
builder.Services.AddDistributedMemoryCache();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromHours(1);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

// ======================
// Seed Admin
// ======================
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<WebDbContext>();
    await SeedAdminAsync(db); // <-- actually call the method
}

// ======================
// Middleware pipeline
// ======================
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthentication();   // Must come before UseAuthorization
app.UseAuthorization();
app.UseSession();


// ======================
// Routing
// ======================
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Form}/{action=Login}");

app.Run();

// ======================
// SeedAdminAsync method
// ======================
static async Task SeedAdminAsync(WebDbContext _Db)
{
    if (!await _Db.Users.AnyAsync(u => u.Email == "admin@example.com"))
    {
        var admin = new Users
        {
            Email = "admin@example.com",
            Role = "Admin"
        };

        // Hash the password properly
        var hasher = new PasswordHasher<Users>();
        admin.Password = hasher.HashPassword(admin, "Admin123"); // <-- your admin password

        _Db.Users.Add(admin);
        await _Db.SaveChangesAsync();
    }
}
