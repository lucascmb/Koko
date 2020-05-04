using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Koko.Domain.Models.EnumModels;

namespace Koko.Domain.Models
{
    public class Product
    {
        public Guid Id { get; set; }
        public TipoProduto ProductType { get; set; }
        public int Amount { get; set; }
        public float ValueAmount { get; set; }

        public Guid AdvisorId { get; set; }
        public Advisor Advisor { get; set; }
        public Guid ClientId { get; set; }
        public Client Client { get; set; }
    }
}
