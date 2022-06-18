
using Snater.Services.Chats.Data;
using Snater.Services.Chats.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using Serilog;
using Serilog.Sinks.Grafana.Loki;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ChatContext>(options => options.UseSqlServer(builder.Configuration.GetConnectionString("LocalDB")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IChatRepository, ChatRepository>();

builder.Host.UseSerilog((ctx, lc) =>
lc.MinimumLevel.Override("Microsoft", Serilog.Events.LogEventLevel.Information)
.Enrich.FromLogContext()
.Enrich.WithProperty("Application", ctx.HostingEnvironment.ApplicationName)
.Enrich.WithProperty("Environment", ctx.HostingEnvironment.EnvironmentName)
.WriteTo.Console(outputTemplate: "[{Timestamp:dd-MM-yyyy HH:mm:ss}] [{Level}] ({SourceContext}) {Message}{NewLine}{Exception}")
.WriteTo.GrafanaLoki(ctx.Configuration["Loki:ServerURL"]));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ChatContext>();
    db.Database.Migrate();
}

app.UseSerilogRequestLogging();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
