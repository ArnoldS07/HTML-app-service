var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// Serve static files from wwwroot
app.UseDefaultFiles(); // Enables default file mapping like index.html
app.UseStaticFiles();  // Enables serving static files

app.Run();
