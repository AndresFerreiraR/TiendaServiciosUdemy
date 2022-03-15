// ***********************************************************************
// Assembly         : TiendaServicios.Api.Libros
// Author           : Andrés Ferreira
// Created          : 15-03-2022
// ***********************************************************************
// <copyright file="ConsultaFiltro.cs" company="Private">
//     Copyright (c) Private. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace TiendaServicios.Api.Libros.Aplicacion
{
    using AutoMapper;
    using MediatR;
    using TiendaServicios.Api.Libros.Modelo;
    using TiendaServicios.Api.Libros.Persistencia;

    /// <summary>
    /// 
    /// </summary>
    public class ConsultaFiltro
    {
        /// <summary>
        /// 
        /// </summary>
        public class LibroUnico : IRequest<LibroMaterialDTO>
        {
            public Guid? LibroId { get; set; }
        }

        /// <summary>
        /// 
        /// </summary>
        public class Manejador : IRequestHandler<LibroUnico, LibroMaterialDTO>
        {
            /// <summary>
            /// 
            /// </summary>
            public readonly ContextoLibreria _Contexto;

            /// <summary>
            /// 
            /// </summary>
            private readonly IMapper _mapper;

            /// <summary>
            /// 
            /// </summary>
            /// <param name="contexto"></param>
            /// <param name="mapper"></param>
            public Manejador(ContextoLibreria contexto, IMapper mapper)
            {
                this._Contexto = contexto;
                _mapper = mapper;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="request"></param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            /// <exception cref="Exception"></exception>
            public async Task<LibroMaterialDTO> Handle(LibroUnico request, CancellationToken cancellationToken)
            {
                //var libroId = Guid.Parse(request.LibroId);
                var libro = _Contexto.LibreriaMaterial.Where(a => a.LibreriaMaterialId == request.LibroId).FirstOrDefault();

                if (libro == null)
                {
                    throw new Exception("El libro no existe");
                }

                var autorDTO = _mapper.Map<LibreriaMaterial, LibroMaterialDTO>(libro);
                return autorDTO;
            }
        }
    }
}