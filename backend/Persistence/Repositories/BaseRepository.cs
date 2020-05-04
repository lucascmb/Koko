using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Koko.Persistence.Contexts;


namespace Koko.Persistence.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly GorilaDbContext _context;

        public BaseRepository(GorilaDbContext context)
        {
            _context = context;
        }
    }
}
