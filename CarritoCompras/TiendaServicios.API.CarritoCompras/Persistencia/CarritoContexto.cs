// ***********************************************************************
// Assembly         : TiendaServicios.API.CarritoCompras
// Author           : Andrés Ferreira
// Created          : 15-03-2022
// ***********************************************************************
// <copyright file="CarritoContexto.cs" company="Private">
//     Copyright (c) Private. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace TiendaServicios.API.CarritoCompras.Persistencia
{
    using Microsoft.EntityFrameworkCore;
    using TiendaServicios.API.CarritoCompras.Modelo;

    /// <summary>
    /// 
    /// </summary>
    public class CarritoContexto : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public CarritoContexto(DbContextOptions<CarritoContexto> options) : base(options)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<CarritoSesionDetalle> CarritoSesionDetalle { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<CarritoSesion> CarritoSesion { get; set; }
    }
}
