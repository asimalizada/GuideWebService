using Autofac;
using Autofac.Extensions.DependencyInjection;
using Core.DataAccess.Concrete.EntityFramework.Contexts;
using Core.DependencyResolvers;
using Core.Extensions;
using Core.Features.IoC;
using Core.Features.Security.Encryption;
using Core.Features.Security.Jwt;
using Core.WebAPI;
using Guide.Business;
using Guide.Business.DependencyResolvers.Autofac;
using Guide.DataAccess.Concrete.EntityFramework.Contexts;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCoreServices(builder.Configuration);
builder.Services.AddGuideServices(builder.Configuration);

builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory()).ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterModule(new AutofacBusinessModule());
});

//builder.Services.AddCors(options =>
//{
//    options.AddPolicy("AllowOrigin",
//        builder => builder.WithOrigins("http://localhost:3000"));
//});

var tokenOptions = builder.Configuration.GetSection("TokenOptions").Get<TokenOptions>();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateIssuer = true,
            ValidateAudience = true,
            ValidateLifetime = true,
            ValidIssuer = tokenOptions.Issuer,
            ValidAudience = tokenOptions.Audience,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = SecurityKeyHelper.CreateSecurityKey(tokenOptions.SecurityKey)
        };
    });

builder.Services.AddDependencyResolvers(new ICoreModule[]
{
    new CoreModule()
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.ConfigureExceptionMiddleware();

app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
