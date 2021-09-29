using GroupMoney_QA_A.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupMoney_QA_A.ComponentHelper
{
    public class NavigationHelper
    {
        public static void NavigateToUrl(string url)
        {
            ObjectRepository.WebDriver.Navigate().GoToUrl(ObjectRepository.Configuration.GetWebSite());
        }
    }
}
