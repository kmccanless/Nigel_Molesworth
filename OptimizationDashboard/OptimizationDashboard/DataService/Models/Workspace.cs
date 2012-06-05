using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CAI.COMMANDoptimize.KPI.Models
{
    public class Workspace
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public KPI[] KPIs { get; set; }
    }
}