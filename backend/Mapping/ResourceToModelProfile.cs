using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Koko.Resources;
using AutoMapper;
using Koko.Domain.Models;

namespace Koko.Mapping
{
    public class ResourceToModelProfile : Profile
    {
        public ResourceToModelProfile()
        {
            CreateMap<SaveInvestorResource, Investor>();
        }
    }
}
