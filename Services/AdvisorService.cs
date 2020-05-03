using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Koko.Domain.Models;
using Koko.Domain.Services;
using Koko.Domain.Repositories;

namespace Koko.Services
{
    public class AdvisorService : IAdvisorService
    {
        private readonly IAdvisorRepository _advisorRepository;
        public AdvisorService(IAdvisorRepository advisorRepository)
        {
            this._advisorRepository = advisorRepository;
        }
        public async Task<IEnumerable<Advisor>> ListAsync()
        {
            return await _advisorRepository.ListAsync();
        }
    }
}
