using Microsoft.AspNetCore.Authentication.JwtBearer;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

const string authenticationProviderKey = "Auth0";

builder.Configuration.AddJsonFile("Ocelot.json");

// Authentication Services

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
}).AddJwtBearer(authenticationProviderKey, options =>
{
    options.Authority = "https://dev-8u4byjyz.eu.auth0.com/";
    options.Audience = "Snater/Gateway";
});

builder.Services.AddOcelot();

var app = builder.Build();

app.UseOcelot();

app.UseHttpsRedirection();

app.UseAuthentication();

app.Run();
