using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Koko.Domain.Models;

namespace Koko.Services.Comunication
{
    public class SaveInvestorResponse : BaseResponse
    {
        public Investor Investor { get; private set; }

        private SaveInvestorResponse(bool success, string message, Investor investor) : base(success, message)
        {
            Investor = investor;
        }

        public SaveInvestorResponse(Investor investor) : this(true, string.Empty, investor) { }

        public SaveInvestorResponse(string message) : this(false, message, null) { }
    }
}
