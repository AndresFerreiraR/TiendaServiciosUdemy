// ***********************************************************************
// Assembly         : TiendaServicios.Test
// Author           : Andrés Ferreira
// Created          : 15-03-2022
// ***********************************************************************
// <copyright file="MappingTest.cs" company="Private">
//     Copyright (c) Private. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace TiendaServicios.Test
{
    using AutoMapper;
    using TiendaServicios.Api.Libros.Aplicacion;
    using TiendaServicios.Api.Libros.Modelo;

    /// <summary>
    /// 
    /// </summary>
    public class MappingTest : Profile
    {
        /// <summary>
        /// 
        /// </summary>
        public MappingTest()
        {
            CreateMap<LibreriaMaterial, LibroMaterialDTO>();
        }
    }
}
