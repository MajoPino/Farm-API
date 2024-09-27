
using DotNetEnv;
using Farm_API.data;
using Microsoft.EntityFrameworkCore;

Env.Load();

//Create the env variables

string putHostDB = Environment.GetEnvironmentVariable("DB_HOST");
string putNameDB = Environment.GetEnvironmentVariable("DB_NAME");
string putPortDB = Environment.GetEnvironmentVariable("DB_PORT");
string putUserNameDB = Environment.GetEnvironmentVariable("DB_USERNAME");
string putPasswordDB = Environment.GetEnvironmentVariable("DB_PASSWORD");

var connectionString = $"server={putHostDB};port={putPortDB};database={putNameDB};uid={putUserNameDB};password={putPasswordDB}";

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseMySql(connectionString, ServerVersion.Parse("8.0.80-mysql")));

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
