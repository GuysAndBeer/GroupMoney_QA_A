using GroupMoney_QA_A.Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.Extensions;

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
    }
}
