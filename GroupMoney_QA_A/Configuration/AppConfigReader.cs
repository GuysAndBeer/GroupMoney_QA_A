using GroupMoney_QA_A.Interfaces;
using GroupMoney_QA_A.Settings;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupMoney_QA_A.Configuration
{
    public class AppConfigReader : IConfig
    {
        public string GetPassword()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Password);
        }

        public string GetUsername()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.Username);
        }

        public BrowserType GetWebDriver()
        {
            return (BrowserType)Enum.Parse(typeof(BrowserType), ConfigurationManager.AppSettings.Get(AppConfigKeys.Browser));
        }

        public string GetWebSite()
        {
            return ConfigurationManager.AppSettings.Get(AppConfigKeys.WebSite);
        }

        public double GetPageLoadTimeout()
        {
            return Convert.ToDouble(ConfigurationManager.AppSettings.Get(AppConfigKeys.PageLoadTimeout));
        }

        public double GetImplicitlyWait()
        {
            return Convert.ToDouble(ConfigurationManager.AppSettings.Get(AppConfigKeys.ImplicitlyWait));
        }
    }
}
