using MenuAPI.DBContext;
using MenuAPI.Repositories;
using Microsoft.EntityFrameworkCore;
using MenuAPI.Repositories;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddDbContext<MenuDbContext>(options =>
    options.UseNpgsql(
        builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped<IMenuRepository, MenuRepository>();
builder.Services.AddControllers();

var app = builder.Build();

app.UseAuthorization();

app.MapControllers();

app.Run();