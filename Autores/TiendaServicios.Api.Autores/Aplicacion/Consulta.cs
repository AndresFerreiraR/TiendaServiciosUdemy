// ***********************************************************************
// Assembly         : TiendaServicios.Api.Autores
// Author           : Andrés Ferreira
// Created          : 15-03-2022
// ***********************************************************************
// <copyright file="Consulta.cs" company="Private">
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
    public class Consulta
    {

        /// <summary>
        /// 
        /// </summary>
        public class ListaAutor : IRequest<List<AutorDTO>>
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public class Manejador : IRequestHandler<ListaAutor, List<AutorDTO>>
        {

            /// <summary>
            /// 
            /// </summary>
            private readonly ContextoAutor _Contexto;

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
                this._mapper = mapper;
            }

            /// <summary>
            /// 
            /// </summary>
            /// <param name="request"></param>
            /// <param name="cancellationToken"></param>
            /// <returns></returns>
            public async Task<List<AutorDTO>> Handle(ListaAutor request, CancellationToken cancellationToken)
            {
                var autores = _Contexto.AutorLibro.ToList();
                var autoresDTO = _mapper.Map<List<AutorLibro>, List<AutorDTO>>(autores);
                return autoresDTO;
            }
        }
    }
}