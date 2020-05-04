using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Koko.Domain.Models.EnumModels;

namespace Koko.Domain.Models
{
    public class Advisor
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public float HeritageAmount { get; set; }
        public int ClientAmount { get; set; }
        public float Rentability { get; set; }
        public bool OpenForNewClients { get; set; }
        public string AdvisorsOffice { get; set; }
        public string Email { get; set; }
        public string Curriculum { get; set; }

        //public IList<GenericString> ProductsAndEspecialist { get; set; } = new List<GenericString>();
        public IList<Product> Products { get; set; } = new List<Product>();
        public IList<Client> Clients { get; set; } = new List<Client>();
        public IList<Depoiment> Depoiment { get; set; } = new List<Depoiment>();
    }
}
