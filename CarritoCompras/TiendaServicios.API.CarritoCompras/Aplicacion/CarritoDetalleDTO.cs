// ***********************************************************************
// Assembly         : TiendaServicios.API.CarritoCompras
// Author           : Andrés Ferreira
// Created          : 15-03-2022
// ***********************************************************************
// <copyright file="CarritoDetalleDTO.cs" company="Private">
//     Copyright (c) Private. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace TiendaServicios.API.CarritoCompras.Aplicacion
{

    /// <summary>
    /// 
    /// </summary>
    public class CarritoDetalleDTO
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? LibroId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string TituloLibro { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string AutorLibro { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? FechaPublicacion { get; set; }
    }
}
