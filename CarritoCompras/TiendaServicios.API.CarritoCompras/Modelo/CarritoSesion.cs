// ***********************************************************************
// Assembly         : TiendaServicios.API.CarritoCompras
// Author           : Andrés Ferreira
// Created          : 15-03-2022
// ***********************************************************************
// <copyright file="CarritoSesion.cs" company="Private">
//     Copyright (c) Private. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace TiendaServicios.API.CarritoCompras.Modelo
{
    /// <summary>
    /// 
    /// </summary>
    public class CarritoSesion
    {
        /// <summary>
        /// 
        /// </summary>
        public int CarritoSesionId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? FechaCreacion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ICollection<CarritoSesionDetalle> ListaDetalle { get; set; }
    }
}
