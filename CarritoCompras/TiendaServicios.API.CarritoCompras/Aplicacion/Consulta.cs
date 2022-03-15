// ***********************************************************************
// Assembly         : TiendaServicios.API.CarritoCompras
// Author           : Andrés Ferreira
// Created          : 15-03-2022
// ***********************************************************************
// <copyright file="Consulta.cs" company="Private">
//     Copyright (c) Private. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace TiendaServicios.API.CarritoCompras.Aplicacion
{
    using MediatR;
    using TiendaServicios.API.CarritoCompras.Persistencia;
    using TiendaServicios.API.CarritoCompras.RemoteInterface;

    /// <summary>
    /// 
    /// </summary>
    public class Consulta
    {
        /// <summary>
        /// 
        /// </summary>
        public class Ejecuta : IRequest<CarritoDTO>
        {
            /// <summary>
            /// 
            /// </summary>
            public int CarritoSesionId { get; set; }
        }

        /// <summary>
        /// 
        /// </summary>
        public class Manejador : IRequestHandler<Ejecuta, CarritoDTO>
        {
            /// <summary>
            /// 
            /// </summary>
            private readonly CarritoContexto _contexto;

            /// <summary>
            /// 
            /// </summary>
            private readonly ILibroService _libroService;

            /// <summary>
            /// 
            /// </summary>
            /// <param name="contexto"></param>
            /// <param name="libroService"></param>
            public Manejador(CarritoContexto contexto, ILibroService libroService)
            {
                this._contexto = contexto;
                this._libroService = libroService;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="request"></param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<CarritoDTO> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                
                var _carritoSesion = _contexto.CarritoSesion.FirstOrDefault(x => x.CarritoSesionId == request.CarritoSesionId);
                
                var carritoSesionDetalle = _contexto.CarritoSesionDetalle.Where(x => x.CarritoSesionId == request.CarritoSesionId).ToList();
                
                var listaCarritoDTO = new List<CarritoDetalleDTO>();
                
                foreach (var libro in carritoSesionDetalle)
                {
                    var response = await _libroService.GetLibro(new Guid(libro.ProductoSeleccionado));
                    
                    if (response.resultado)
                    {
                        var objetoLibro = response.Libro;
                        
                        var carritoDetalle = new CarritoDetalleDTO
                        {
                            TituloLibro = objetoLibro.Titulo,
                            FechaPublicacion = objetoLibro.FechaPublicacion,
                            LibroId = objetoLibro.LibreriaMaterialId,
                        };

                        listaCarritoDTO.Add(carritoDetalle);
                    }
                }

                var carritoSesionDTO = new CarritoDTO()
                {
                    CarritoId = _carritoSesion.CarritoSesionId,
                    FechaCreacionSesion = _carritoSesion.FechaCreacion,
                    ListaProductos = listaCarritoDTO,
                };

                return carritoSesionDTO;
            }
        }
    }
}
