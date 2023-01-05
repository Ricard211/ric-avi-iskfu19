using Microsoft.EntityFrameworkCore;
using ric_avi_iskfu19.DataModels;
using ric_avi_iskfu19.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<HelmetContext>(options =>
    options
        .UseNpgsql(builder.Configuration.GetConnectionString("ConnectDB"))
        .UseSnakeCaseNamingConvention());

builder.Services.AddScoped<HelmetService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
