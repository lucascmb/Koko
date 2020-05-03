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
    public class InvestorRepository : BaseRepository, IInvestorRepository
    {
        public InvestorRepository(GorilaDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Investor>> ListAsync()
        {
            return await _context.Investors.ToListAsync();
        }

        public async Task AddAsync(Investor investor)
        {
            await _context.Investors.AddAsync(investor);
        }
    }
}
