using GroupMoney_QA_A.Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;

namespace GroupMoney_QA_A.ComponentHelper
{
    public class GenericHelper
    {
        public static bool IsElementPresented(By by)
        {
            try
            {
                return ObjectRepository.WebDriver.FindElements(by).Count == 1;
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static IWebElement GetWebElement(By by)
        {
            if(IsElementPresented(by))
                return ObjectRepository.WebDriver.FindElement(by);
            throw new NoSuchElementException("No such element: " + by.ToString());
        }

        public static IWebElement GetWebElement(string text)
        {
            var locator = By.XPath($"//button[text()={text}]");
            if (IsElementPresented(locator))
                return ObjectRepository.WebDriver.FindElement(locator);
            throw new NoSuchElementException("No such element: " + text);
        }

        public static void TakeScreenShot(string filename = "Screen")
        {
            Screenshot screenshot = ObjectRepository.WebDriver.TakeScreenshot();
            if (filename.Equals("Screen"))
            {
                screenshot.SaveAsFile(filename + DateTime.Now.ToString("yyyy-MM-dd-mm-ss") + ".jpeg", 
                    ScreenshotImageFormat.Jpeg); 
                return;
            }
            screenshot.SaveAsFile(filename, ScreenshotImageFormat.Jpeg);
        }

        public static bool WaitForWebElement(By locator, TimeSpan timeout)
        {
            ObjectRepository.WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            WebDriverWait wait = new WebDriverWait(ObjectRepository.WebDriver, timeout);
            wait.PollingInterval = TimeSpan.FromMilliseconds(250);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            bool flag = wait.Until(WaitForWebElementFunc(locator));
            ObjectRepository.WebDriver.Manage().Timeouts().ImplicitWait =
                TimeSpan.FromSeconds(ObjectRepository.Configuration.GetImplicitlyWait());
            return flag;
        }

        public static Func<IWebDriver, bool> WaitForWebElementFunc(By locator)
        {
            return ((x) =>
            {
                if (x.FindElements(locator).Count == 1)
                    return true;
                return false;
            });
        }

        public static IWebElement WaitForWebElementInPage(By locator, TimeSpan timeout)
        {
            ObjectRepository.WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(1);
            WebDriverWait wait = new WebDriverWait(ObjectRepository.WebDriver, timeout);
            wait.PollingInterval = TimeSpan.FromMilliseconds(250);
            wait.IgnoreExceptionTypes(typeof(NoSuchElementException), typeof(ElementNotVisibleException));
            IWebElement element = wait.Until(WaitForWebElementInPageFunc(locator));
            ObjectRepository.WebDriver.Manage().Timeouts().ImplicitWait =
                TimeSpan.FromSeconds(ObjectRepository.Configuration.GetImplicitlyWait());
            return element;
        }

        public static Func<IWebDriver, IWebElement> WaitForWebElementInPageFunc(By locator)
        {
            return ((x) =>
            {
                if (x.FindElements(locator).Count == 1)
                    return x.FindElement(locator);
                return null;
            });
        }
    }
}
