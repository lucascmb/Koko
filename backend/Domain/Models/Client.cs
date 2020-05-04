    using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Koko.Domain.Models
{
    public class Client
    {
        public Guid Id { get; set; }
        public float HeritageAmount {get;set;}

        public IList<Product> Products { get; set; } = new List<Product>();
        public Guid AdvisorId { get; set; }
        public Advisor Advisor { get; set; }
    }
}
