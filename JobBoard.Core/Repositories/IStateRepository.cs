﻿using JobBoard.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace JobBoard.Core.Repositories
{
    public interface IStateRepository
    {
        Task<IEnumerable<State>> GetStatesByCountryIdAsync(int countryId);
    }
}
