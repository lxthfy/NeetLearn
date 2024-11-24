using Microsoft.EntityFrameworkCore;
using Neet.Data;

var builder = WebApplication.CreateBuilder(args);

// Konfigurasi DbContext menggunakan PostgreSQL
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseNpgsql("Host=localhost;Port=5432;Database=NeetDB;Username=postgres;Password=12345678;")); // Ganti dengan string koneksi Anda

// Tambahkan Swagger ke layanan
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Aktifkan Swagger hanya di lingkungan Development
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Endpoint default untuk memastikan aplikasi berjalan
app.MapGet("/", () => "Hello, Swagger!");

// Jalankan aplikasi
app.Run();
