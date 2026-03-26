using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using PizzasBD.Api.BusinessLayer;
using PizzasBD.Api.Data;
using PizzasBD.Api.Interfaces;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<IAdicionalBL, AdicionalBL>();
builder.Services.AddScoped<IBebidaBL, BebidaBL>();
builder.Services.AddScoped<IMasaBL, MasaBL>();
builder.Services.AddScoped<IMenuBL, MenuBL>();
builder.Services.AddScoped<IPizzaBL, PizzaBL>();
builder.Services.AddScoped<IPollosBL, PollosBL>();
builder.Services.AddScoped<ITamanioBL, TamanioBL>();

builder.Services.AddDbContext<AppDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Pizzas API BD",
        Description = "Tarea de la semana 1. Misma funcionalidad, con conexión a base de datos",
        Contact = new OpenApiContact
        {
            Name = "Francisco Bucio",
            Email = "fbucio.castillo@gmail.com"
        }
    });
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseStaticFiles();

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<AppDbContext>();
    Seeder.Seed(context);
}

app.Run();
