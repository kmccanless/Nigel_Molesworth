﻿using System;

using CAI.COMMANDoptimize.KPI.Models;
using CAI.COMMANDoptimize.KPI.Repositories;

namespace CAI.COMMANDoptimize.KPI.Dataservice
{
    public interface IKPIDataService
    {
        string GetKPI(string username, string location, string pollTime);
    }

    public class KPIDataService : IKPIDataService
    {
        public KPIDataService(IRepositoryFactory rf)
        {
            _rf = rf;
        }

        #region IKPIDataService Members

        public string GetKPI(string username, string location, string pollTime)
        {
            IKPIRepository r = _rf.GetRepository();

            User user = r.GetUser(username);
            user.ActiveLocation = location;
            user.PollTime = pollTime;
            Workspace[] workspaces = r.GetKPIs(user.Role, location, user.Locations);

            string json = JsonConverter.ToJSON<KPIDATA_JSON>(new KPIDATA_JSON(user, workspaces));

            return json;
        }

        #endregion

        private IRepositoryFactory _rf;
    }
}