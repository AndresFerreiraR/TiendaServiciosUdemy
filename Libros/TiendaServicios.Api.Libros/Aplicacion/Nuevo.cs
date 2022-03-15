// ***********************************************************************
// Assembly         : TiendaServicios.Api.Libros
// Author           : Andrés Ferreira
// Created          : 15-03-2022
// ***********************************************************************
// <copyright file="Nuevo.cs" company="Private">
//     Copyright (c) Private. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace TiendaServicios.Api.Libros.Aplicacion
{
    using FluentValidation;
    using MediatR;
    using TiendaServicios.Api.Libros.Modelo;
    using TiendaServicios.Api.Libros.Persistencia;

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
            public string Titulo { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public DateTime? FechaPublicacion {get;set;}

            /// <summary>
            /// 
            /// </summary>
            public Guid? AutorLibro {get;set;}
        }

        /// <summary>
        /// 
        /// </summary>
        public class EjecutarValidacion : AbstractValidator<Ejecuta>
        {
            /// <summary>
            /// 
            /// </summary>
            public EjecutarValidacion()
            {
                RuleFor(l => l.Titulo).NotEmpty();
                RuleFor(l => l.FechaPublicacion).NotEmpty();
                RuleFor(l => l.AutorLibro).NotEmpty();
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
            public readonly ContextoLibreria _Contexto;
            
            /// <summary>
            /// 
            /// </summary>
            /// <param name="contexto"></param>
            public Manejador(ContextoLibreria contexto)
            {
                this._Contexto = contexto;
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
                var libreriaMaterial = new LibreriaMaterial
                {
                    Titulo = request.Titulo,
                    FechaPublicacion = request.FechaPublicacion,
                    AutorLibro = request.AutorLibro,
                    LibreriaMaterialId = Guid.NewGuid()
                };

                _Contexto.LibreriaMaterial.Add(libreriaMaterial);
                var valor = await _Contexto.SaveChangesAsync();
                return valor > 0 ? Unit.Value : throw new Exception("No se pudo insertar el libro");
            }
        }
    }
}