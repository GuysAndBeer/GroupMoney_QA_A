using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupMoney_QA_A.Settings;
using OpenQA.Selenium;

namespace GroupMoney_QA_A.ComponentHelper
{
    public class JavaScriptPopHelper
    {
        public static bool IsPopupDisplayed()
        {
            try
            {
                ObjectRepository.WebDriver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }

        public static string GetPopupText()
        {
            if (IsPopupDisplayed())
                return ObjectRepository.WebDriver.SwitchTo().Alert().Text;
            return null;
        }

        public static void AcceptPopup()
        {
            if (IsPopupDisplayed())
                ObjectRepository.WebDriver.SwitchTo().Alert().Accept();
        }

        public static void DeclinePopup()
        {
            if (IsPopupDisplayed())
                ObjectRepository.WebDriver.SwitchTo().Alert().Dismiss();
        }

        public static void SendTextPopup(string text)
        {
            if (IsPopupDisplayed())
                ObjectRepository.WebDriver.SwitchTo().Alert().SendKeys(text);
        }
    }
}
