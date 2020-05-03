using Koko.Domain.Models;
using Koko.Domain.Repositories;
using Koko.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Koko.Persistence.Repositories
{
    public class ClientRepository : BaseRepository, IClientRepository
    {
        public ClientRepository(GorilaDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Client>> FindAsync(Guid Id)
        {
            return await _context.Clients.Where(p => p.AdvisorId == Id).ToListAsync();
        }

        public async Task<IEnumerable<Client>> ListAsync()
        {
            return await _context.Clients.ToListAsync();
        }
    }
}
