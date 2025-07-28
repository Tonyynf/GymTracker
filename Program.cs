using System.Data.Common;
using GymTracker.Data;
using Microsoft.Extensions.Options;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Adiciona serviços da API
builder.Services.AddControllers(); // <-- Essencial
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=gymtracker.db")); // ou o banco que estiver usando
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    // Ativa Swagger
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

// Mapeia controllers
app.MapControllers(); // <-- Ativa rotas do tipo /api/controller

app.Run();