﻿using System.Collections.Generic;
using System.Threading.Tasks;

namespace GIO_14BlazorLibrary.DataAccess
{
    public interface ISqlDataAccess
    {
        Task<List<T>> LoadDataAsync<T, U>(string storedProcedure, U parameters, string connectionStringName);
        Task SaveDataAsync<T>(string storedProcedure, T parameters, string connectionStringName);
    }
}