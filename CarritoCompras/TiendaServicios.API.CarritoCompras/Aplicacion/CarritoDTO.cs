// ***********************************************************************
// Assembly         : TiendaServicios.API.CarritoCompras
// Author           : Andrés Ferreira
// Created          : 15-03-2022
// ***********************************************************************
// <copyright file="CarritoDTO.cs" company="Private">
//     Copyright (c) Private. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace TiendaServicios.API.CarritoCompras.Aplicacion
{
    /// <summary>
    /// 
    /// </summary>
    public class CarritoDTO
    {
        /// <summary>
        /// 
        /// </summary>
        public int CarritoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? FechaCreacionSesion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public List<CarritoDetalleDTO> ListaProductos { get; set; }
    }
}
