using BeerStore.Db;
using BeerStore.Db.Repositories;
using BeerStore.UseCases.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddTransient<ISubdivisionRepository, SubdivisionRepository>();
builder.Services.AddDbContext<DatabaseContext>(options =>
    options.UseNpgsql(builder.Configuration.GetConnectionString("BeerStoreContext")));

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseCors(policy => policy
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
