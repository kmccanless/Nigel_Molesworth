﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using CAI.COMMANDoptimize.KPI.Dataservice;
using CAI.COMMANDoptimize.KPI.Repositories;

namespace OptimizationDashboard
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string username = Request["userName"];
            string location = Request["location"];
            string pollTime = Request["pollTime"];

            //Set a default poll time
            if (string.IsNullOrEmpty(pollTime))
            {
                //None supplied; default to 5 minutes
                pollTime = "300000";
            }

            if (!string.IsNullOrEmpty(username))
            {

                IRepositoryConfiguration c = new RepositoryConfiguration();
                IRepositoryFactory f = new RepositoryFactory(c);
                IKPIDataService ds = new KPIDataService(f);

                string json = ds.GetKPI(username, location, pollTime);

                //Response.ContentType = "text/json";
                Response.Write(json);
            }
            else
            {
                Response.StatusCode = 400;   
                Response.Write("Invalid username specified");
            }

        }
    }
}
