using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Koko.Domain.Models;
using Koko.Services.Comunication;

namespace Koko.Domain.Services
{
    public interface IInvestorService
    {
        Task<IEnumerable<Investor>> ListAsync();
        Task<SaveInvestorResponse> SaveAsync(Investor investor);
    }
}
