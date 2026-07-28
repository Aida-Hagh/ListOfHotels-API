using ListOfHotels_Core.Interfaces;
using ListOfHotels_Data.Data;
using ListOfHotels_Data.UnitOfWork;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Serilog;
using Serilog.Events;

var builder = WebApplication.CreateBuilder(args);


//******1- تنظیمات Serilog ********
#region Serilog Setting

Log.Logger = new LoggerConfiguration()
    .WriteTo.Console()
    .WriteTo.File(
    path: "logs\\log-.txt",
    outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} [{Level:u3}] {Message:lj}{NewLine}{Exception}",
    rollingInterval: RollingInterval.Day,
    restrictedToMinimumLevel: LogEventLevel.Information)
    .CreateLogger();

try
{
    Log.Information("Application Is Starting");
    builder.Host.UseSerilog();
}
catch (Exception ex)
{
    Log.Fatal(ex, "Application Failed to start");
}
finally
{
    Log.CloseAndFlush();
}

#endregion


//database
builder.Services.AddDbContext<AppDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("sqlConnection")));


builder.Services.AddScoped<IUnitOfWork,UnitOfWork>();

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();


//********4 فعال‌سازی CORS برای دسترسی از دامنه‌های دیگر (فقط برای توسعه)
// اجازه می‌ده برنامه‌های دیگر (مثل React یا Vue) به این API وصل بشن.

builder.Services.AddCors(o =>
{
    o.AddPolicy("AllowAll", builder =>
        builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());
});

//*******2.تنظیمات سفارشی برای Swagger
builder.Services.AddSwaggerGen(c =>
c.SwaggerDoc("v1", new OpenApiInfo
{
    Title = "ListOfHotels-API",
    Version = "v1",
    Description = "API for managing hotel listings"
}));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    //*******3.تنظیمات سفارشی برای Swagger
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Hotel Listing API"));
}

app.UseHttpsRedirection();
//***** 5 ******
app.UseCors("AllowAll");

app.UseAuthorization();

app.MapControllers();

app.Run();
