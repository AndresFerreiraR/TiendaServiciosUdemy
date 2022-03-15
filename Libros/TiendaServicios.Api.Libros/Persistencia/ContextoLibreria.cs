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
namespace TiendaServicios.Api.Libros.Persistencia
{
    using Microsoft.EntityFrameworkCore;
    using TiendaServicios.Api.Libros.Modelo;

    /// <summary>
    /// 
    /// </summary>
    public class ContextoLibreria : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        public ContextoLibreria()
        {

        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public ContextoLibreria(DbContextOptions<ContextoLibreria> options) : base(options)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public virtual DbSet<LibreriaMaterial> LibreriaMaterial { get; set; }
    }
}
