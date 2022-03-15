// ***********************************************************************
// Assembly         : TiendaServicios.Api.Libros
// Author           : Andrés Ferreira
// Created          : 15-03-2022
// ***********************************************************************
// <copyright file="Consulta.cs" company="Private">
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
    public class Consulta
    {
        /// <summary>
        /// 
        /// </summary>
        public class Ejecuta : IRequest<List<LibroMaterialDTO>> { }

        /// <summary>
        /// 
        /// </summary>
        public class Manejador : IRequestHandler<Ejecuta, List<LibroMaterialDTO>>
        {

            /// <summary>
            /// 
            /// </summary>
            private readonly ContextoLibreria _Contexto;

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
                this._mapper = mapper;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="request"></param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<List<LibroMaterialDTO>> Handle(Ejecuta request, CancellationToken cancellationToken)
            {
                var libros = _Contexto.LibreriaMaterial.ToList();
                var libreriaMaterial = _mapper.Map<List<LibreriaMaterial>, List<LibroMaterialDTO>>(libros);
                return libreriaMaterial;
            }
        }
    }
}