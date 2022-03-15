// ***********************************************************************
// Assembly         : TiendaServicios.Api.Libros
// Author           : Andrés Ferreira
// Created          : 15-03-2022
// ***********************************************************************
// <copyright file="MappingProfile.cs" company="Private">
//     Copyright (c) Private. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace TiendaServicios.Api.Libros.Aplicacion
{
    using AutoMapper;
    using TiendaServicios.Api.Libros.Modelo;

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
            CreateMap<LibreriaMaterial, LibroMaterialDTO>();
        }
    }
}