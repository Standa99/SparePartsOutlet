
using Microsoft.EntityFrameworkCore;
using SparePartsOutletApp.Context;
using SparePartsOutletApp.Context.SeedData;
using SparePartsOutletApp.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var connectionStringDev = builder.Configuration["ConnectionStrings:Development"];

builder.Services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(connectionStringDev));

builder.Services.AddScoped<ISeedData, SeedData>();
builder.Services.AddSingleton<IUserManagementService, UserManagementService>();


var app = builder.Build();



//app.MapGet("/", () => "Hello World!");

app.UseStaticFiles();
app.UseRouting();
app.MapControllers();

app.Run();
