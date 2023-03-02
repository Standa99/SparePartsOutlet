
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using SparePartsOutletApp.Context;
using SparePartsOutletApp.Context.SeedData;
using SparePartsOutletApp.Context.SeedData._Interfaces;
using SparePartsOutletApp.Services;
using SparePartsOutletApp.Services._Interfaces;
using SparePartsOutletApp.Services.Repositories;
using SparePartsOutletApp.Services.Repositories._Interfaces;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
<<<<<<< HEAD
=======

>>>>>>> user-JWT-implemetation
    options.TokenValidationParameters = new TokenValidationParameters
    {
        ValidateIssuer = true,
        ValidateAudience = true,
        ValidateLifetime = true,
        ValidateIssuerSigningKey = true,
        ValidIssuer = builder.Configuration["Jwt:Issuer"],
        ValidAudience = builder.Configuration["Jwt:Audience"],
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["Jwt:Key"]))
    });


var connectionStringDev = builder.Configuration["ConnectionStrings:Development"];

builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(connectionStringDev));

//builder.Services.AddScoped<AppDbContext>();
builder.Services.AddScoped<ISeedData, SeedData>();
builder.Services.AddScoped<IUserManagementService, UserManagementService>();
builder.Services.AddScoped<ITokenService, TokenService>();
builder.Services.AddScoped<IUserRepository, UserRepository>();
<<<<<<< HEAD
=======
builder.Services.AddHttpContextAccessor();
>>>>>>> user-JWT-implemetation


var app = builder.Build();



//app.MapGet("/", () => "Hello World!");

app.UseStaticFiles();
app.UseRouting();
app.UseAuthentication();

app.UseAuthorization();
app.MapControllers();

app.Run();
