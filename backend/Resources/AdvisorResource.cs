using Koko.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Koko.Resources
{
    public class AdvisorResource
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public float HeritageAmount { get; set; }
        public int ClientAmount { get; set; }
        public float Rentability { get; set; }
        public bool OpenForNewClients { get; set; }
    }
}
