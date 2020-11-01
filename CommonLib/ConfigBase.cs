using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommonLib
{
    public static class ConfigBase
    {
        public static string GetConfigAppSettingValueByKey(string KEY)
        {
            return ConfigurationManager.AppSettings[KEY].ToString();
        }
        public static string GetConfigConfigConnectionString(string CONNECTION_STRING)
        {
            return ConfigurationManager.ConnectionStrings[CONNECTION_STRING].ConnectionString; ;
        }
    }
}
