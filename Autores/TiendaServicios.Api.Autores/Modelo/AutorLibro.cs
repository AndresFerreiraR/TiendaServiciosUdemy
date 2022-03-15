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
    /// Clase que implementa las propiedades de la entidad AutorLibro
    /// </summary>
    public class AutorLibro
    {
        /// <summary>
        /// Obntiene o establece un valor para AutorLibroId
        /// </summary>
        public int AutorLibroId { get; set; }

        /// <summary>
        /// Obntiene o establece un valor para Nombre
        /// </summary>
        public string Nombre { get; set; }

        /// <summary>
        /// Obntiene o establece un valor para Apellido
        /// </summary>
        public string Apellido { get; set; }

        /// <summary>
        /// Obntiene o establece un valor para FechaNacimiento
        /// </summary>
        public DateTime? FechaNacimiento { get; set; }

        /// <summary>
        /// Obntiene o establece un valor para ListaGradoAcademico
        /// </summary>
        public ICollection<GradoAcademico> ListaGradoAcademico { get; set; }

        /// <summary>
        /// Obntiene o establece un valor para AutorLibroGuid
        /// </summary>
        public string AutorLibroGuid { get; set; }
    }
}
