using System;

namespace CAI.COMMANDoptimize.KPI.Models
{
    public static class JsonConverter
    {
        public static string ToJSON<T>(T o)
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(o);
        }
    }

    public class KPIDATA_JSON
    {
        private User _user;
        private Workspace[] _workspaces;

        public KPIDATA_JSON(User user, Workspace[] workspaces)
        {
            _user = user;
            _workspaces = workspaces;
        }
        
        public string userName
        {
            get { return _user.Username; }            
        }
        
        public string roleName
        {
            get { return _user.Role; }
        }

        public string activeLocation
        {
            get { return _user.ActiveLocation; }
        }

        public string pollTime
        {
            get { return _user.PollTime; }
        }

        public string[] locations
        {
            get { return _user.Locations; }
        }
        
        public Workspace_JSON[] workspaces
        {
            get 
            {
                return new Workspace_JSON[] {
                    new Workspace_JSON(_workspaces[0]),
                    new Workspace_JSON(_workspaces[1])
                };
            }
        }        
    }
    
    public class Workspace_JSON
    {        
        private Workspace _workspace;

        public Workspace_JSON(Workspace workspace)
        {            
            _workspace = workspace;
        }
        public int id
        {
            get { return _workspace.Code.ToLower().StartsWith("a") ? 1 : 2; }
        }
        public KPI_JSON[] KPIs
        {
            get 
            {
                KPI_JSON[] kpis = new KPI_JSON[_workspace.KPIs.Length];
                for (int i = 0; i < kpis.Length; i++)
                {
                    kpis[i] = new KPI_JSON(_workspace.KPIs[i]);
                }

                return kpis;
            }
        }
    }

    public class KPI_JSON
    {
        private KPI _kpi;        

        public KPI_JSON(KPI kpi)
        {
            _kpi = kpi;            
        }

        public string title
        {
            get { return _kpi.Description; }
        }
        public string type
        {
            get { return _kpi.Category; }
        }
        public decimal value
        {
            get { return _kpi.Actual; }
        }
        public decimal target
        {
            get { return _kpi.Target; }
        }
        public decimal units
        {
            get { return _kpi.Units; }
        }
        public decimal firstWarn
        {
            get { return _kpi.Level1; }
        }
        public decimal secondWarn
        {
            get { return _kpi.Level2; }
        }
    }
}