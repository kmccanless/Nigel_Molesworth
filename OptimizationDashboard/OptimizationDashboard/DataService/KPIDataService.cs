﻿using System;

using CAI.COMMANDoptimize.KPI.Models;
using CAI.COMMANDoptimize.KPI.Repositories;

namespace CAI.COMMANDoptimize.KPI.Dataservice
{
    public interface IKPIDataService
    {
        string GetKPI(string username, string location);
    }

    public class KPIDataService : IKPIDataService
    {
        public KPIDataService(IRepositoryFactory rf)
        {
            _rf = rf;
        }

        #region IKPIDataService Members

        public string GetKPI(string username, string location)
        {
            IKPIRepository r = _rf.GetRepository();

            User user = r.GetUser(username);
            if (user != null)
            {
                user.ActiveLocation = location;
                Workspace[] workspaces = r.GetKPIs(user.Role, location, user.Locations);

                string json = JsonConverter.ToJSON<KPIDATA_JSON>(new KPIDATA_JSON(user, workspaces));

                return json;
            }
            else
            {
                return "{\"error\": \"No user found for " + username + "\"}";
            }
        }

        #endregion

        private IRepositoryFactory _rf;
    }
}