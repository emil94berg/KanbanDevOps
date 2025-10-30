var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Kollar automatiskt efter index.html (och default.html etc.)
app.UseDefaultFiles(); 

// Serverar statiska filer från wwwroot
app.UseStaticFiles();

app.Run();