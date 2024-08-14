using BeerMaker.Api.Services;
using Domain.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<IRecipeService, RecipeService>();
//builder.Services.AddScoped<IRecipeService, RecipeServiceOldStyle>();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseAuthorization();

app.MapControllers();

app.Run();
