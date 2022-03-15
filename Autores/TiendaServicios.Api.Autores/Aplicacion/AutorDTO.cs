// ***********************************************************************
// Assembly         : TiendaServicios.Api.Autores
// Author           : Andr�s Ferreira
// Created          : 15-03-2022
// ***********************************************************************
// <copyright file="AutorDTO.cs" company="Private">
//     Copyright (c) Private. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace TiendaServicios.Api.Autores.Aplicacion
{
    /// <summary>
    /// 
    /// </summary>
    public class AutorDTO
    {
        /// <summary>
        /// 
        /// </summary>
        public string Nombre {get;set;}

        /// <summary>
        /// 
        /// </summary>
        public string Apellido {get;set;}

        /// <summary>
        /// 
        /// </summary>
        public DateTime? FechaNacimiento {get;set;}

        /// <summary>
        /// 
        /// </summary>
        public string AutorLibroGuid {get;set;}
    }
}