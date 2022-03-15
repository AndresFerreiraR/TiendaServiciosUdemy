// ***********************************************************************
// Assembly         : TiendaServicios.API.CarritoCompras
// Author           : Andrés Ferreira
// Created          : 15-03-2022
// ***********************************************************************
// <copyright file="ILibroService.cs" company="Private">
//     Copyright (c) Private. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace TiendaServicios.API.CarritoCompras.RemoteInterface
{
    using TiendaServicios.API.CarritoCompras.RemoteModel;

    /// <summary>
    /// 
    /// </summary>
    public interface ILibroService
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="LibroId"></param>
        /// <returns></returns>
        Task<(bool resultado, LibroRemote Libro, string ErrorMessage)> GetLibro(Guid LibroId);
    }
}
