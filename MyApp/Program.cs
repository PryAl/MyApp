using BusinessLogic;
using BusinessLogic.Services;
using DataAccess;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using WebApp.Helpers;

var builder = WebApplication.CreateBuilder(args);

//Config
ConfigurationManager configuration = builder.Configuration;
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Mapper
builder.Services.AddAutoMapper(typeof(MappingProfile));

//DB
builder.Services.AddDbContext<MyDbContext>(opt => opt.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
    b => b.MigrationsAssembly("WebApp")));

builder.Services.AddScoped<IEntityService<Premise>, PremiseService>();
builder.Services.AddScoped<IEntityService<Room>, RoomService>();
builder.Services.AddScoped<IEntityService<Device>, DeviceService>();
builder.Services.AddScoped<IEntityRepository<Premise>, PremiseRepository>();
builder.Services.AddScoped<IEntityRepository<Room>, RoomRepository>();
builder.Services.AddScoped<IEntityRepository<Device>, DeviceRepository>();

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
