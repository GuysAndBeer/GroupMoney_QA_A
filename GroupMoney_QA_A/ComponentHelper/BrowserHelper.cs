using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupMoney_QA_A.Settings;
using OpenQA.Selenium;

namespace GroupMoney_QA_A.ComponentHelper
{
    class BrowserHelper
    {
        public static void BrowserMaximize()
        {
            ObjectRepository.WebDriver.Manage().Window.Maximize();
        }

        public static void GoForward()
        {
            ObjectRepository.WebDriver.Navigate().Forward();
        }

        public static void GoBack()
        {
            ObjectRepository.WebDriver.Navigate().Back();
        }

        public static void RefreshThePage()
        {
            ObjectRepository.WebDriver.Navigate().Refresh();
        }

        public static void SwitchToWindow(int index = 0)
        {
            ReadOnlyCollection<string> windows = ObjectRepository.WebDriver.WindowHandles;
            if (windows.Count <= index)
                throw new  NoSuchWindowException();
            ObjectRepository.WebDriver.SwitchTo().Window(windows[index]);
            BrowserMaximize();
        }

        public static void SwitchToParentWindow()
        {
            ReadOnlyCollection<string> windows = ObjectRepository.WebDriver.WindowHandles;
            for (int i = windows.Count-1; i > 0; i--)
            {
                ObjectRepository.WebDriver.Close();
                SwitchToWindow(i-1);
            }
            BrowserMaximize();
        }

        public static void SwitchToFrame(By locator)
        {
            ObjectRepository.WebDriver.SwitchTo().
                Frame(ObjectRepository.WebDriver.FindElement(locator));
        }

        public static void SwitchToDefaultContent()
        {
            ObjectRepository.WebDriver.SwitchTo().DefaultContent();
        }
    }
}
