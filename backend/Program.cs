using CartorioCivilApi.Data;
using CartorioCivilApi.Repositories;
using CartorioCivilApi.Services;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Banco de dados (SQLite como exemplo)
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite("Data Source=cartorio.db"));

// Injeção de dependência
builder.Services.AddScoped<INascimentoRepository, NascimentoRepository>();
builder.Services.AddScoped<NascimentoService>();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
