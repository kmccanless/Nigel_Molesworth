using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CAI.COMMANDoptimize.KPI.Models
{
    public class KPI
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public int Ordinal { get; set; }
        public decimal Actual { get; set; }
        public decimal Units { get; set; }
        public decimal Target { get; set; }
        public decimal Level1 { get; set; }
        public decimal Level2 { get; set; }
    }
}