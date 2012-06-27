using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CAI.COMMANDoptimize.KPI.Models
{
    public class User
    {
        public string Username { get; set; }
        public string Role { get; set; }
        public string ActiveLocation { get; set; }
        public string[] Locations { get; set; }
        //public Workspace[] Workspaces { get; set; }
    }
}