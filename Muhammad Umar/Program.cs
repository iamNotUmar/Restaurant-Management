using Microsoft.EntityFrameworkCore;
using Muhammad_Umar.DBContext;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllersWithViews();

var provider= builder.Services.BuildServiceProvider();
var configuration = provider.GetRequiredService<IConfiguration>();
builder.Services.AddDbContext<StdDBContext>(item => item.UseSqlServer(configuration.GetConnectionString("myconn")));

var app = builder.Build();

if(!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();
app.UseRouting();
app.MapControllerRoute(
    name: "defult",
    pattern: "{Controller=Home}/{action=Index}/{id?}");



app.Run();
