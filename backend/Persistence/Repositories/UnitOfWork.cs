using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Koko.Domain.Repositories;
using Koko.Persistence.Contexts;

namespace Koko.Persistence.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GorilaDbContext _context;

        public UnitOfWork(GorilaDbContext context)
        {
            _context = context;
        }

        public async Task CompleteAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
