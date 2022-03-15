// ***********************************************************************
// Assembly         : TiendaServicios.API.CarritoCompras
// Author           : Andrés Ferreira
// Created          : 15-03-2022
// ***********************************************************************
// <copyright file="LibrosService.cs" company="Private">
//     Copyright (c) Private. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace TiendaServicios.API.CarritoCompras.RemoteService
{
    using System.Text.Json;
    using TiendaServicios.API.CarritoCompras.RemoteInterface;
    using TiendaServicios.API.CarritoCompras.RemoteModel;

    /// <summary>
    /// 
    /// </summary>
    public class LibrosService : ILibroService
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly IHttpClientFactory _httpClient;

        /// <summary>
        /// 
        /// </summary>
        private readonly ILogger _logger;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="httpClient"></param>
        /// <param name="logger"></param>
        public LibrosService(IHttpClientFactory httpClient = null, ILogger logger = null)
        {
            this._httpClient = httpClient;
            this._logger = logger;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="LibroId"></param>
        /// <returns></returns>
        public async Task<(bool resultado, LibroRemote Libro, string ErrorMessage)> GetLibro(Guid LibroId)
        {
            try
            {
                var cliente = _httpClient.CreateClient("Libros");
                var response = await cliente.GetAsync($"api/Libromaterial/{LibroId}");
                if (response.IsSuccessStatusCode)
                {
                    var contenido = await response.Content.ReadAsStringAsync();
                    var options = new JsonSerializerOptions() { PropertyNameCaseInsensitive = true };

                    var resultado = JsonSerializer.Deserialize<LibroRemote>(contenido, options);

                    return (true, resultado, null);
                }

                return (false, null, response.ReasonPhrase);
            }
            catch (Exception e)
            {
                _logger?.LogError(e.ToString());
                return (false, null, e.Message); 
            }
        }
    }
}
