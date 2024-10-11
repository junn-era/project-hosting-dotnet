using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectHosting.Models
{
    public class Suite
    {
        public Suite() { }

        public Suite(string suiteType, int capacity, decimal nightlyRate)
        {
            SuiteType = suiteType;
            Capacity = capacity;
            NightlyRate = nightlyRate;
        }

        public string SuiteType { get; set; }
        public int Capacity { get; set; }
        public decimal NightlyRate { get; set; }
    }
}