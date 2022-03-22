using Microsoft.EntityFrameworkCore;
using FollowSys.Models;
using FollowSys.Data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<FollowSysContext>(options =>
   options.UseSqlite(builder.Configuration.GetConnectionString("MyDbContextSqlite")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    SeedData.Initialize(services);
}

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
