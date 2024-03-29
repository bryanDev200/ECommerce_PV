using ECommerce_BusinessL.IServices;
using ECommerce_BusinessL.IServicesImpl;
using ECommerce_DAL;
using ECommerce_DAL.Implementations;
using ECommerce_DAL.Interfaces;
using ECommerce_DAL.IServices;
using ECommerce_DAL.SercvicesImpl;
using ECommerce_EntityL.Models;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<ICrudRepository<User>, UserDA>();
builder.Services.AddScoped<ICategory, CategoryDA>();
builder.Services.AddScoped<IRole, RoleDA>();
builder.Services.AddScoped<ICategoryService, CategoryService>();
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("ConnectionString")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
