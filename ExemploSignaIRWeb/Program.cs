using ExemploSignaIRWeb.Hubs;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddRazorPages();
builder.Services.AddSignalR();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseStaticFiles();

app.MapRazorPages();
app.MapHub<ChatHub>("/chatHub");

app.MapControllerRoute("default", "{controller=home}/{action=index}/{id?}");

app.Run();