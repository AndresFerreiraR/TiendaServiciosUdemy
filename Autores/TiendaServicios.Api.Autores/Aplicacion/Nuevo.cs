// ***********************************************************************
// Assembly         : TiendaServicios.Api.Autores
// Author           : Andrés Ferreira
// Created          : 15-03-2022
// ***********************************************************************
// <copyright file="Nuevo.cs" company="Private">
//     Copyright (c) Private. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace TiendaServicios.Api.Autores.Aplicacion
{
    using System;
    using FluentValidation;
    using MediatR;
    using TiendaServicios.Api.Autores.Modelo;
    using TiendaServicios.Api.Autores.Persistencia;

    /// <summary>
    /// 
    /// </summary>
    public class Nuevo
    {
        /// <summary>
        /// 
        /// </summary>
        public class Ejecuta : IRequest
        {
            /// <summary>
            /// 
            /// </summary>
            public string Nombre { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public string Apellido { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public DateTime? FechaNacimiento { get; set; }
        }

        /// <summary>
        /// 
        /// </summary>
        public class EjecutaValidacion : AbstractValidator<Ejecuta>
        {
            /// <summary>
            /// 
            /// </summary>
            public EjecutaValidacion() 
            {
                RuleFor(a => a.Nombre).NotEmpty();
                RuleFor(a => a.Apellido).NotEmpty();
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public class Manejador : IRequestHandler<Ejecuta>
        {
            /// <summary>
            /// 
            /// </summary>
            public readonly ContextoAutor _contexto;

            /// <summary>
            /// 
            /// </summary>
            /// <param name="contexto"></param>
            public Manejador(ContextoAutor contexto)
            {
                this._contexto = contexto;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="request"></param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            /// <exception cref="Exception"></exception>
            public async Task<Unit> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var autorLibro = new AutorLibro
                {
                    Nombre = request.Nombre,
                    Apellido = request.Apellido,
                    FechaNacimiento = request.FechaNacimiento,
                    AutorLibroGuid = Guid.NewGuid().ToString(),
                };

                _contexto.AutorLibro.Add(autorLibro);
                var valor = await _contexto.SaveChangesAsync();
                return valor > 0 ? Unit.Value : throw new Exception("No se pudo insertar el autor del libro");
            }
        }
    }
}