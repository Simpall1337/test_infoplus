using Microsoft.Data.SqlClient;
using test_infoplus;
using DataAccessLayer.Data;
using BussinesLogicLayer;
using DataAccessLayer.Interfaces;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
string connectionString = "Server=DESKTOP-ES2FHTF;Database=test_infoplus;Trusted_Connection=true;TrustServerCertificate=True;";
builder.Services.AddScoped<DbConnect>(provider =>
{
    return new DbConnect(connectionString);
});
builder.Services.AddScoped<IStoresRepository, StoresRepository>()
                .AddScoped<IStoresServise, StoresServise>()
                .AddScoped<IEquipmentRepository, EquipmentRepository>()
                .AddScoped<IEquipmentService, EquipmentService>()
                .AddScoped<IInventoryRepository, InventoryRepository>()
                .AddScoped<IInventoryService, InventoryService>();
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
