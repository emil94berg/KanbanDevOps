using System.Reflection;
using FirstRiderWebApp.wwwroot.lib.DAL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseNpgsql(connectionString));

var app = builder.Build();

// Kollar automatiskt efter index.html (och default.html etc.)
app.UseDefaultFiles(); 
// Serverar statiska filer från wwwroot
app.UseStaticFiles();

app.Run();