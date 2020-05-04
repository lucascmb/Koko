using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Koko.Domain.Models;
using Koko.Resources;

namespace Koko.Mapping
{
    public class ModelToResourceProfile : Profile
    {
        public ModelToResourceProfile()
        {
            CreateMap<Investor, InvestorResource>();
            CreateMap<Advisor, AdvisorResource>();
            CreateMap<Client, ClientResource>();
        }
    }
}
