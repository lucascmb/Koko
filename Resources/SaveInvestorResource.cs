using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Koko.Domain.Models.EnumModels;

namespace Koko.Resources
{
    public class SaveInvestorResource
    {
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Telephone { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public float Balance { get; set; }
        [Required]
        public float ExpectRentability { get; set; }
        [Required]
        public string Objective { get; set; }
        [Required]
        public string InvestmentHorizon { get; set; }
        [Required]
        public Suitability Suitability { get; set; }
    }
}
