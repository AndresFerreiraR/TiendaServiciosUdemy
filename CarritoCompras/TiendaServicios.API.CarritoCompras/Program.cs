using MediatR;
using Microsoft.EntityFrameworkCore;
using TiendaServicios.API.CarritoCompras.Aplicacion;
using TiendaServicios.API.CarritoCompras.Persistencia;
using TiendaServicios.API.CarritoCompras.RemoteInterface;
using TiendaServicios.API.CarritoCompras.RemoteService;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddScoped<ILibroService, LibrosService>();
builder.Services.AddControllers();

builder.Services.AddDbContext<CarritoContexto>(options =>
{
    var mariaDbVersion = new MariaDbServerVersion(new Version(10, 4, 12));
    options.UseMySql(builder.Configuration.GetConnectionString("ConexionDataBase"), mariaDbVersion);
});
builder.Services.AddMediatR(typeof(Nuevo.Manejador).Assembly);

/// builder.Services.AddControllers().AddFluentValidation(cfg => cfg.RegisterValidatorsFromAssemblyContaining<Nuevo>());
builder.Services.AddAutoMapper(typeof(Consulta.Manejador));
builder.Services.AddHttpClient("Libros", config =>
{
    config.BaseAddress = new Uri(builder.Configuration["Services:Libros"]);
});


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
