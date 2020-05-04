using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Koko.Domain.Models
{
    public class Depoiment
    {
        public Guid Id { get; set; }
        public string PersonName { get; set; }
        public string Text { get; set; }
        
        public Advisor Advisor { get; set; }
        public Guid AdvisorId { get; set; }
    }
}
