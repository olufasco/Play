using Microsoft.EntityFrameworkCore;
using Play.Data;
using Play.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddScoped<ITodoService, TodoService>();
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<TodoContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();
app.UseStaticFiles();
app.UseRouting();
app.MapDefaultControllerRoute();
app.Run();