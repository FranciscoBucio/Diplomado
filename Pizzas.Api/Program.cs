using Microsoft.OpenApi.Models;
using Pizzas.Api.Services;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddScoped<AdicionalService>();
builder.Services.AddScoped<BebidaService>();
builder.Services.AddScoped<MasaService>();
builder.Services.AddScoped<MenuService>();
builder.Services.AddScoped<PizzaService>();
builder.Services.AddScoped<PolloService>();
builder.Services.AddScoped<TamanioService>();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    options.SwaggerDoc("v1", new OpenApiInfo
    {
        Version = "v1",
        Title = "Pizzas API",
        Description = "Tarea de la semana 1",
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

app.Run();
