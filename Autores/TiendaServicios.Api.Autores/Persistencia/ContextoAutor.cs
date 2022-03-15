// ***********************************************************************
// Assembly         : TiendaServicios.Api.Autores
// Author           : Andrés Ferreira
// Created          : 15-03-2022
// ***********************************************************************
// <copyright file="ContextoAutor.cs" company="Private">
//     Copyright (c) Private. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace TiendaServicios.Api.Autores.Persistencia
{
    using Microsoft.EntityFrameworkCore;
    using TiendaServicios.Api.Autores.Modelo;

    /// <summary>
    /// 
    /// </summary>
    public class ContextoAutor : DbContext
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="options"></param>
        public ContextoAutor(DbContextOptions<ContextoAutor> options) : base(options)
        {

        }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<AutorLibro> AutorLibro { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DbSet<GradoAcademico> GradoAcademico { get; set; }
    }
}
