﻿using JobBoard.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JobBoard.Core.Repositories
{
    public interface ICountryRepository
    {
        Task<IEnumerable<Country>> GetCountriesAsync();
        Task<IEnumerable<Country>> GetCountriesWithStatesAsync();
        Task<Country> GetCountryAsync(int id);
    }
}
