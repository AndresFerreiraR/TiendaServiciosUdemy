// ***********************************************************************
// Assembly         : TiendaServicios.API.CarritoCompras
// Author           : Andrés Ferreira
// Created          : 15-03-2022
// ***********************************************************************
// <copyright file="Nuevo.cs" company="Private">
//     Copyright (c) Private. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace TiendaServicios.API.CarritoCompras.Aplicacion
{
    using MediatR;
    using TiendaServicios.API.CarritoCompras.Modelo;
    using TiendaServicios.API.CarritoCompras.Persistencia;

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
            public DateTime FechaCreacionSesion { get; set; }

            /// <summary>
            /// 
            /// </summary>
            public List<string> ProductoLista { get; set; }
        }

        /// <summary>
        /// 
        /// </summary>
        public class Manejador : IRequestHandler<Ejecuta>
        {
            /// <summary>
            /// 
            /// </summary>
            public readonly CarritoContexto _contexto;

            /// <summary>
            /// 
            /// </summary>
            /// <param name="contexto"></param>
            public Manejador(CarritoContexto contexto)
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
                var carritoSesion = new CarritoSesion
                {
                    FechaCreacion = request.FechaCreacionSesion,
                };

                _contexto.CarritoSesion.Add(carritoSesion);
                var value = await _contexto.SaveChangesAsync();

                if(value == 0)
                {
                    throw new Exception("Error en la insersion del carrito compras");
                }

                int id = carritoSesion.CarritoSesionId;

                request.ProductoLista.ForEach(pl =>
                {
                    var detalleSesion = new CarritoSesionDetalle
                    {
                        FechaCreacion = DateTime.Now,
                        CarritoSesionId = id,
                        ProductoSeleccionado = pl
                    };

                    _contexto.CarritoSesionDetalle.Add(detalleSesion);
                });

                value = await _contexto.SaveChangesAsync();

                if(value == 0)
                {
                    throw new Exception("No se pudo insertar el detalle del carrito de compras");
                }

                return Unit.Value;
            }
        }
    }
}
