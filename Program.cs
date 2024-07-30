using Dating_App.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

//connection string
builder.Services.AddDbContext<DataContext>(options =>
{
    var connectionstring = builder.Configuration.GetConnectionString("DefaultConnection");
    options.UseSqlServer(connectionstring);
});

var app = builder.Build();

// Configure the HTTP request pipeline.
app.MapControllers();

app.Run();
