using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Koko.Domain.Models;

namespace Koko.Domain.Services
{
    public interface IAdvisorService
    {
        Task<IEnumerable<Advisor>> ListAsync();
    }
}
