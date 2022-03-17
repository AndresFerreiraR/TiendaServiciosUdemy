global using System;
global using Microsoft.AspNetCore.Builder;
global using Microsoft.Extensions.Hosting;
using FluentValidation.AspNetCore;
using MediatR;
using Microsoft.EntityFrameworkCore;
using TiendaServicios.Api.Libros.Aplicacion;
using TiendaServicios.Api.Libros.Persistencia;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddDbContext<ContextoLibreria>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ContextoLirbos"));
});

builder.Services.AddMediatR(typeof(Nuevo.Manejador).Assembly);
builder.Services.AddControllers().AddFluentValidation(cfg => cfg.RegisterValidatorsFromAssemblyContaining<Nuevo>());
builder.Services.AddAutoMapper(typeof(Consulta.Manejador));


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
