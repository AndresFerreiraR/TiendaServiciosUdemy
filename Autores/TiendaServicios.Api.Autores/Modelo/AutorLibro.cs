// ***********************************************************************
// Assembly         : TiendaServicios.Api.Autores
// Author           : Andrés Ferreira
// Created          : 15-03-2022
// ***********************************************************************
// <copyright file="AutorLibro.cs" company="Private">
//     Copyright (c) Private. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace TiendaServicios.Api.Autores.Modelo
{
    /// <summary>
    /// 
    /// </summary>
    public class AutorLibro
    {
        /// <summary>
        /// 
        /// </summary>
        public int AutorLibroId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Apellido { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? FechaNacimiento { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public ICollection<GradoAcademico> ListaGradoAcademico { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string AutorLibroGuid { get; set; }
    }
}
