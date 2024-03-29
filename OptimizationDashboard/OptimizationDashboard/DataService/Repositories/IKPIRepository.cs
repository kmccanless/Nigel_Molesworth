﻿using System;

using CAI.COMMANDoptimize.KPI.Models;

namespace CAI.COMMANDoptimize.KPI.Repositories
{
    public interface IKPIRepository
    {
        User GetUser(string username);
        Workspace[] GetKPIs(string rolename, string location, string[] locations);
    }
}
