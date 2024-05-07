using MotorizedMarvels;
using System.Data.SqlClient;
using MotorizedMarvels.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddAuthentication();


builder.Services.AddScoped<IWeatherService, WeatherService>();
builder.Services.AddScoped<ILoginService, LoginService>();  


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Register the DatabaseService class
builder.Services.AddSingleton<DatabaseService>();

var app = builder.Build();


// Load configuration from appsettings.json
var configuration = new ConfigurationBuilder()
    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
    .Build();

// Get the connection string
var connectionString = configuration.GetConnectionString("MyDatabaseConnection");

// Configure the database connection
builder.Services.AddSingleton(_ => new SqlConnection(connectionString));

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();

//var abc = app.Services.GetService<IWeatherService>();

