using ĐTSDay9Lesson.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// 🔹 Lấy chuỗi kết nối trước
var connectString = builder.Configuration.GetConnectionString("DtsDay9Lab_Connection");

// 🔹 Đăng ký DbContext (phải làm trước khi Build)
builder.Services.AddDbContext<DtsCFContext>(options =>
    options.UseSqlServer(connectString));

// 🔹 Đăng ký MVC
builder.Services.AddControllersWithViews();

var app = builder.Build();

// 🔹 Cấu hình pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}

app.UseStaticFiles();
app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();