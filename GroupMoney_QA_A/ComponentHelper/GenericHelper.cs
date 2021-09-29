using GroupMoney_QA_A.Settings;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
