using GroupMoney_QA_A.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupMoney_QA_A.CustomException;

namespace GroupMoney_QA_A.ComponentHelper
{
    public class NavigationHelper
    {
        public static void NavigateToUrl(string url = "")
        {
            if (url.Equals(string.Empty)) url = ObjectRepository.Configuration.GetWebSite();
            ObjectRepository.WebDriver.Navigate().GoToUrl(url);
        }

        public static string GetTheUrl(string pageName)
        {
            switch (pageName)
            {
                case "Home":
                    return "";
                case "Login":
                    return ObjectRepository.Configuration.GetWebSite() + "login.html";
                case "Main":
                    return ObjectRepository.Configuration.GetWebSite() + "main.html";
                default:
                    throw new NoSuchPageFound($"There is no such page: {pageName}");
            }
        }

        public static string GetThePageTitle()
        {
            return ObjectRepository.WebDriver.Title;
        }
    }
}
