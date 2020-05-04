using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Koko.Domain.Models;
using Koko.Domain.Services;
using AutoMapper;
using Koko.Resources;

namespace Koko.Controllers
{
    [Route("[controller]")]
    public class AdvisorsController : Controller
    {
        private readonly IAdvisorService _advisorService;
        private readonly IMapper _mapper;

        public AdvisorsController(IAdvisorService advisorService, IMapper mapper)
        {
            _advisorService = advisorService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<AdvisorResource>> GetAllAsync()
        {
            var advisors = await _advisorService.ListAsync();

            var resources = _mapper.Map<IEnumerable<Advisor>, IEnumerable<AdvisorResource>>(advisors);

            return resources;
        }
    }
}
