using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Web;

namespace HealthService.Helper
{
    public static class ConfigHelper
    {
        public static String GetCSVPath(String modelName)
        {
            String csvPath = String.Empty;

            switch (modelName)
            {
                case "Claim":
                    csvPath = ConfigurationManager.AppSettings["ClaimCSV"];
                    break;

                case "Member":
                    csvPath = ConfigurationManager.AppSettings["MemberCSV"];
                    break;
            }

            return Path.Combine(HttpContext.Current.Server.MapPath("~\\"), csvPath);
        }
    }
}