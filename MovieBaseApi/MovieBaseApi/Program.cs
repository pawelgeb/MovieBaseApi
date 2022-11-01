using Microsoft.EntityFrameworkCore;
using MovieBaseApi.Data;

var builder = WebApplication.CreateBuilder(args);
var dataBaseChose = "SQL";

// Add services to the container.

if (dataBaseChose != "SQL")
{
    builder.Services.AddDbContext<MovieContext>(opt => opt.UseInMemoryDatabase("MovieBaseList"));
}
else
{
    builder.Services.AddDbContext<MovieContext>(op => op.UseNpgsql(builder.Configuration.GetConnectionString("MovieBaseConnection")));
}

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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
