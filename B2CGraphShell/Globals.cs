using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B2CGraphShell
{
    public static class Globals
    {
        public static string aadInstance = "https://login.microsoftonline.com/";
        public static string aadGraphResourceId = "https://graph.windows.net/";
        public static string aadGraphEndpoint = "https://graph.windows.net/";
        public static string aadGraphSuffix = "";
        public static string aadGraphVersion = "api-version=1.6";

        public static string tenant = ConfigurationManager.AppSettings["b2c:Tenant"];
        public static string clientId = ConfigurationManager.AppSettings["b2c:ClientId"];
        public static string clientSecret = ConfigurationManager.AppSettings["b2c:ClientSecret"];
    }
}
