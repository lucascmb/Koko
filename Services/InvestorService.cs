using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Koko.Domain.Models;
using Koko.Domain.Services;
using Koko.Domain.Repositories;
using Koko.Services.Comunication;

namespace Koko.Services
{
    public class InvestorService : IInvestorService
    {
        private readonly IInvestorRepository _investorRepository;
        private readonly IUnitOfWork _unitOfWork;

        public InvestorService(IInvestorRepository investorRepository, IUnitOfWork unitOfWork)
        {
            _investorRepository = investorRepository;
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<Investor>> ListAsync()
        {
            return await _investorRepository.ListAsync();
        }

        public async Task<SaveInvestorResponse> SaveAsync(Investor investor)
        {
            try
            {
                await _investorRepository.AddAsync(investor);
                await _unitOfWork.CompleteAsync();

                return new SaveInvestorResponse(investor);
            }

            catch(Exception ex)
            {
                return new SaveInvestorResponse($"Um erro ocorreu durante a criação do investidor: {ex.Message}");
            }
        }
    }
}
