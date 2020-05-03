using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Koko.Domain.Models;
using Koko.Domain.Services;
using Koko.Domain.Repositories;

namespace Koko.Services
{
    public class ClientService : IClientService
    {
        private readonly IClientRepository _clientRepository;
        public ClientService(IClientRepository clientRepository)
        {
            this._clientRepository = clientRepository;
        }
        public async Task<IEnumerable<Client>> FindAsync(Guid Id)
        {
            return await _clientRepository.FindAsync(Id);
        }
        public async Task<IEnumerable<Client>> ListAsync()
        {
            return await _clientRepository.ListAsync();
        }
    }
}
