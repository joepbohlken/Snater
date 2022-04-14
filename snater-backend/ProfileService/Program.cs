using Microsoft.EntityFrameworkCore;
using Snater.Services.Profile.Data;
using Snater.Services.Profile.Data.Interfaces;
using Snater.Services.Profile.Services;
using Snater.Services.Profile.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddScoped<IProfileService, ProfileService>();
builder.Services.AddScoped<IProfileRepository, ProfileRepository>();

builder.Services.AddDbContext<ProfileContext>(options => 
    options.UseSqlServer(builder.Configuration.GetConnectionString("DockerDB")));

// Add services to the container.
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAnyOrigin",
        builder => builder
        .AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader());
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseCors("AllowAnyOrigin");

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
