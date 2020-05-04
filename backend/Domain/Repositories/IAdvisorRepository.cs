using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Koko.Domain.Models;

namespace Koko.Domain.Repositories
{
    public interface IAdvisorRepository
    {
        Task<IEnumerable<Advisor>> ListAsync();
    }
}
