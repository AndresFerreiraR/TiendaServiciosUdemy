// ***********************************************************************
// Assembly         : TiendaServicios.API.CarritoCompras
// Author           : Andrés Ferreira
// Created          : 15-03-2022
// ***********************************************************************
// <copyright file="LibroRemote.cs" company="Private">
//     Copyright (c) Private. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace TiendaServicios.API.CarritoCompras.RemoteModel
{
    /// <summary>
    /// 
    /// </summary>
    public class LibroRemote
    {
        /// <summary>
        /// 
        /// </summary>
        public Guid? LibreriaMaterialId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Titulo { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public DateTime? FechaPublicacion { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Guid? AutorLirbo { get; set; }
    }
}
