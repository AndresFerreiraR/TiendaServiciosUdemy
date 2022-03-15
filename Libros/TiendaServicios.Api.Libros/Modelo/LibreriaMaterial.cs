// ***********************************************************************
// Assembly         : TiendaServicios.Api.Libros
// Author           : Andrés Ferreira
// Created          : 15-03-2022
// ***********************************************************************
// <copyright file="LibreriaMaterial.cs" company="Private">
//     Copyright (c) Private. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace TiendaServicios.Api.Libros.Modelo
{
    /// <summary>
    /// 
    /// </summary>
    public class LibreriaMaterial
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? LibreriaMaterialId {get;set;}

        /// <summary>
        /// 
        /// </summary>
        public string Titulo {get;set;}

        /// <summary>
        /// 
        /// </summary>
        public DateTime? FechaPublicacion {get;set;}

        /// <summary>
        /// 
        /// </summary>
        public Guid? AutorLibro {get;set;}
    }
}