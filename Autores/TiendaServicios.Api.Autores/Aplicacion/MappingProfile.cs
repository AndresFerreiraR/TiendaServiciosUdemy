// ***********************************************************************
// Assembly         : TiendaServicios.Api.Autores
// Author           : Andrés Ferreira
// Created          : 15-03-2022
// ***********************************************************************
// <copyright file="MappingProfile.cs" company="Private">
//     Copyright (c) Private. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace TiendaServicios.Api.Autores.Aplicacion
{
    using AutoMapper;
    using TiendaServicios.Api.Autores.Modelo;

    /// <summary>
    /// 
    /// </summary>
    public class MappingProfile : Profile
    {
        /// <summary>
        /// 
        /// </summary>
        public MappingProfile()
        {
            CreateMap<AutorLibro, AutorDTO>();
        }
    }
}