//web uygulamasının insa edilmesi
var builder = WebApplication.CreateBuilder(args);
//servis kaydi
builder.Services.AddControllersWithViews();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseRouting();

app.MapControllerRoute("default","{controller=home}/{action=index}/{id?}");

app.Run();

// \ {} []