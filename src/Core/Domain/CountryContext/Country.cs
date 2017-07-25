﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OfficeLocationMicroservice.Core.Domain.CountryContext
{
    public class Country
    {
        public int CountryId { get; set; }
        public string Name { get; set; }
        public string Slug { get; set; }
    }
}
