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
    public class AdvisorRepository : BaseRepository, IAdvisorRepository
    {
        public AdvisorRepository(GorilaDbContext context) : base(context)
        {

        }

        public async Task<IEnumerable<Advisor>> ListAsync()
        {
            return await _context.Advisors.ToListAsync();
        }
    }
}
