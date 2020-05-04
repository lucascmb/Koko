using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Koko.Domain.Models;

namespace Koko.Domain.Repositories
{
    public interface IInvestorRepository
    {
        Task<IEnumerable<Investor>> ListAsync();
        Task AddAsync(Investor investor);
    }
}
