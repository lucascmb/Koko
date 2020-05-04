using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Koko.Domain.Models;
using Koko.Domain.Services;
using AutoMapper;
using Koko.Resources;
using System;

namespace Koko.Controllers
{
    [Route("[controller]")]
    public class ClientsController : Controller
    {
        private readonly IClientService _clientService;
        private readonly IMapper _mapper;

        public ClientsController(IClientService clientService, IMapper mapper)
        {
            _clientService = clientService;
            _mapper = mapper;
        }

        [HttpGet("{Id}")]
        public async Task<IEnumerable<ClientResource>> GetFromAdvisorIdAsync(Guid Id)
        {
            var clients = await _clientService.FindAsync(Id);

            var resources = _mapper.Map<IEnumerable<Client>, IEnumerable<ClientResource>>(clients);

            return resources;
        }

        [HttpGet]
        public async Task<IEnumerable<ClientResource>> GetAllAsync()
        {
            var clients = await _clientService.ListAsync();

            var resources = _mapper.Map<IEnumerable<Client>, IEnumerable<ClientResource>>(clients);

            return resources;
        }
    }
}
