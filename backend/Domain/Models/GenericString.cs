using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Koko.Domain.Models
{
    public class GenericString
    {
        public Guid Id { get; set; }
        public Type Type { get; set; }
        public string Name { get; set; }

        public Advisor Advisor { get; set; }
        public Guid AdvisorId { get; set; }
    }
}
