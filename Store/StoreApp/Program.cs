//web uygulamasının insa edilmesi
using Microsoft.EntityFrameworkCore;
using StoreApp.Models;

var builder = WebApplication.CreateBuilder(args);
//servis kaydi
builder.Services.AddControllersWithViews();
//ProductController dosyası icin onemli
builder.Services.AddDbContext<RepositoryContext>(options =>
{
    options.UseSqlite(builder.Configuration.GetConnectionString("sqlconnection"));
});
var app = builder.Build();

app.UseHttpsRedirection();
app.UseRouting();

app.MapControllerRoute("default","{controller=home}/{action=index}/{id?}");

app.Run();

// \ {} []