// ***********************************************************************
// Assembly         : TiendaServicios.Test
// Author           : Andrés Ferreira
// Created          : 15-03-2022
// ***********************************************************************
// <copyright file="AsyncEnumerator.cs" company="Private">
//     Copyright (c) Private. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace TiendaServicios.Test
{
    using System;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    /// <summary>
    /// Clase que evalua el arerglo de tipo T que retorna el mock de EF
    /// </summary>
    /// <typeparam name="T">parametro de tipo T</typeparam>
    public class AsyncEnumerator<T> : IAsyncEnumerator<T>
    {
        /// <summary>
        /// Variable global de tipo IEnumerator
        /// </summary>
        private readonly IEnumerator<T> enumerator;

        /// <summary>
        /// variable que trabaja internamente de tipo T
        /// </summary>
        public T Current => enumerator.Current;

        /// <summary>
        /// Inicializa una nueva instancia de la clase AsyncEnumerator
        /// </summary>
        /// <param name="enumerator">inicializa el enumerador con la variable global</param>
        /// <exception cref="ArgumentNullException">En caso de no obtener data de la variable global retorna una excepcion</exception>
        public AsyncEnumerator(IEnumerator<T> enumerator) => this.enumerator = enumerator ?? throw new ArgumentNullException();

        /// <summary>
        /// Retorna si la tarea a finalizado
        /// </summary>
        /// <returns></returns>
        public async ValueTask DisposeAsync()
        {
            await Task.CompletedTask;
        }

        /// <summary>
        /// retonrna los siguientes valores dentro del arreglo
        /// </summary>
        /// <returns>retorna si existe un nuevo elemento</returns>
        public async ValueTask<bool> MoveNextAsync()
        {
            return await Task.FromResult(enumerator.MoveNext());
        }
    }
}
