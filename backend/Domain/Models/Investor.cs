﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Koko.Domain.Models.EnumModels;

namespace Koko.Domain.Models
{
    public class Investor
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public string Password { get; set; }
        public float Balance { get; set; }
        public float ExpectRentability { get; set; }
        public string Objective { get; set; }
        public string InvestmentHorizon { get; set; }
        public Suitability Suitability { get; set; }

        //public Product [] Products { get; set; }
        // public Interesse Interesses { get; set; }
    }
}
