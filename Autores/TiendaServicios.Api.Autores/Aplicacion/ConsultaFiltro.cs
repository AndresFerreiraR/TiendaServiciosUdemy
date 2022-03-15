// ***********************************************************************
// Assembly         : TiendaServicios.Api.Autores
// Author           : Andrés Ferreira
// Created          : 15-03-2022
// ***********************************************************************
// <copyright file="ConsultaFiltro.cs" company="Private">
//     Copyright (c) Private. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace TiendaServicios.Api.Autores.Aplicacion
{
    using AutoMapper;
    using MediatR;
    using TiendaServicios.Api.Autores.Modelo;
    using TiendaServicios.Api.Autores.Persistencia;

    /// <summary>
    /// 
    /// </summary>
    public class ConsultaFiltro
    {
        /// <summary>
        /// 
        /// </summary>
        public class AutorUnico : IRequest<AutorDTO>
        {
            /// <summary>
            /// 
            /// </summary>
            public string AutorGuid { get; set; }
        }

        /// <summary>
        /// 
        /// </summary>
        public class Manejador : IRequestHandler<AutorUnico, AutorDTO>
        {
            /// <summary>
            /// 
            /// </summary>
            public readonly ContextoAutor _Contexto;

            /// <summary>
            /// 
            /// </summary>
            private readonly IMapper _mapper;

            /// <summary>
            /// 
            /// </summary>
            /// <param name="contexto"></param>
            /// <param name="mapper"></param>
            public Manejador(ContextoAutor contexto, IMapper mapper)
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
            public async Task<AutorDTO> Handle(AutorUnico request, CancellationToken cancellationToken)
            {
                var autor = _Contexto.AutorLibro.Where(a => a.AutorLibroGuid == request.AutorGuid).FirstOrDefault();

                if (autor == null)
                {
                    throw new Exception("El Autor no existe");
                }

                var autorDTO = _mapper.Map<AutorLibro, AutorDTO>(autor);
                return autorDTO;
            }
        }
    }
}