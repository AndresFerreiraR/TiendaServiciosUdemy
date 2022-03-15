// ***********************************************************************
// Assembly         : TiendaServicios.Api.Libros
// Author           : Andrés Ferreira
// Created          : 15-03-2022
// ***********************************************************************
// <copyright file="LibromaterialController.cs" company="Private">
//     Copyright (c) Private. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace TiendaServicios.Api.Libros.Controllers
{
    using MediatR;
    using Microsoft.AspNetCore.Mvc;
    using TiendaServicios.Api.Libros.Aplicacion;

    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    [Route("[controller]")]
    public class LibromaterialController : ControllerBase
    {
        /// <summary>
        /// 
        /// </summary>
        private readonly IMediator _mediator;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="mediator"></param>
        public LibromaterialController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="data"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<ActionResult<Unit>> Crear(Nuevo.Ejecuta data)
        {
            return await _mediator.Send(data);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult<List<LibroMaterialDTO>>> Consulta()
        {
            return await _mediator.Send(new Consulta.Ejecuta());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet("{id}")]
        public async Task<ActionResult<LibroMaterialDTO>> ConsultaPorId(Guid? id)
        {
            return await _mediator.Send(new ConsultaFiltro.LibroUnico{LibroId = id});
        }
    }
}