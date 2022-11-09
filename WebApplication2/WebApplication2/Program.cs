using Microsoft.EntityFrameworkCore;
using WebApplication2.Data;
using WebApplication2.Model.Domain;
using WebApplication2.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Data base conection injection(Dependency injection)
builder.Services.AddDbContext<WalksDbContext>(options =>
{
    DbContextOptionsBuilder dbContextOptionsBuilder = options.UseSqlServer(builder.Configuration.GetConnectionString("Walks"));
});

builder.Services.AddScoped<IRegionRepository, RegionRepository>();

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
