using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Koko.Domain.Models;
using Koko.Domain.Services;
using AutoMapper;
using Koko.Resources;
using Koko.Extensions;
using Twilio;
using Twilio.Rest.Api.V2010.Account;

namespace Koko.Controllers
{
    [Route("[controller]")]
    public class InvestorsController : Controller
    {
        private readonly IInvestorService _investorService;
        private readonly IMapper _mapper;

        public InvestorsController(IInvestorService investorService, IMapper mapper)
        {
            _investorService = investorService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IEnumerable<InvestorResource>> GetAllAsync()
        {
            var investors = await _investorService.ListAsync();
            var resources = _mapper.Map<IEnumerable<Investor>, IEnumerable<InvestorResource>>(investors);

            return resources;
        }

        [HttpPost]
        public async Task<IActionResult> PostAsync([FromBody] SaveInvestorResource resource)
        {

            if (!ModelState.IsValid) return BadRequest(ModelState.GetErrorMessages());

            var investor = _mapper.Map<SaveInvestorResource, Investor>(resource);

            var result = await _investorService.SaveAsync(investor);

            if (!result.Success) return BadRequest(result.Message);

            var investorResource = _mapper.Map< Investor, InvestorResource>(result.Investor);

            return Ok(investorResource);
        }
    }
}
