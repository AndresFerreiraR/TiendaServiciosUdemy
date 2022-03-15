// ***********************************************************************
// Assembly         : TiendaServicios.Api.Autores
// Author           : Andrés Ferreira
// Created          : 15-03-2022
// ***********************************************************************
// <copyright file="GradoAcademico.cs" company="Private">
//     Copyright (c) Private. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace TiendaServicios.Api.Autores.Modelo
{

    /// <summary>
    /// 
    /// </summary>
    public class GradoAcademico
    {
        /// <summary>
        /// 
        /// </summary>
        public int GradoAcademicoId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string CentroAcademico { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? FechaGrado { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public int AutorLibroId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public AutorLibro AutorLibro { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string GradoAcademicoGuid { get; set; }
    }
}
