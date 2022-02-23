﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataAcess.DataServices
{
    public interface IDataServices
    {
        /// <summary>
        /// Gets all data from DB
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        Task<List<T>> GetAllData<T>();

        /// <summary>
        /// Gets table data by ID
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task<T> GetDataByID<T>(string Id);

        /// <summary>
        /// Updates table data 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tdata"></param>
        /// <returns></returns>
        Task UpSertData<T>(string Id, T tdata);

        /// <summary>
        /// Method Adds new data
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="tdata"></param>
        /// <returns></returns>
        Task AddData<T>(T tdata);

        /// <summary>
        /// Deletes table data
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="Id"></param>
        /// <returns></returns>
        Task DeleteData<T>(string Id);
    }
}
