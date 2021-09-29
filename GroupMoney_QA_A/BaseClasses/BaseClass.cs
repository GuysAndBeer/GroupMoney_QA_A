using GroupMoney_QA_A.ComponentHelper;
using GroupMoney_QA_A.Configuration;
using GroupMoney_QA_A.CustomException;
using GroupMoney_QA_A.Settings;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupMoney_QA_A.BaseClasses
{
    [TestClass]
    class BaseClass
    {
        private static ChromeOptions GetChromeOptions()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArgument("start-maximized");
            return options;
        }

        private static InternetExplorerOptions GetIExplorerOptions()
        {
            InternetExplorerOptions options = new InternetExplorerOptions();
            options.IntroduceInstabilityByIgnoringProtectedModeSettings = true;
            options.EnsureCleanSession = true;
            return options;
        }

        private static IWebDriver GetChromeDriver()
        {
            return new ChromeDriver(GetChromeOptions());
        }

        private static IWebDriver GetIExplorerDriver()
        {
            return new InternetExplorerDriver(GetIExplorerOptions());
        }

        [AssemblyInitialize]
        public static void InitDriver(TestContext context)
        {
            ObjectRepository.Configuration = new AppConfigReader();
            switch (ObjectRepository.Configuration.GetWebDriver())
            {
                case BrowserType.Chrome:
                    ObjectRepository.WebDriver = GetChromeDriver();
                    break;
                case BrowserType.IExplorer:
                    ObjectRepository.WebDriver = GetIExplorerDriver();
                    break;
                default:
                    throw new NoSuitableDriverFound("Driver not found: " + ObjectRepository.Configuration.GetWebDriver());
            }
            NavigationHelper.NavigateToUrl("");
        }

        [AssemblyCleanup]
        public static void CleanupDriver()
        {
            if (ObjectRepository.WebDriver != null)
                ObjectRepository.WebDriver.Quit();
        }
    }
}
