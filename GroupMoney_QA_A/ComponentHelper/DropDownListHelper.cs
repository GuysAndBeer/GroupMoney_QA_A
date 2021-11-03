using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace GroupMoney_QA_A.ComponentHelper
{
    public class DropDownListHelper
    {
        public static void SelectElement(By by, string text)
        {
            new SelectElement(GenericHelper.GetWebElement(by)).SelectByValue(text);
        }

        public static void SelectElement(By by, int index)
        {
            new SelectElement(GenericHelper.GetWebElement(by)).SelectByIndex(index);
        }

        public static List<string> GetAllItems(By by)
        {
            return new SelectElement(GenericHelper.GetWebElement(by)).Options.
                Select((item) => item.Text).ToList();
        }

        public static string GetSelectedItem(By by)
        {
            return new SelectElement(GenericHelper.GetWebElement(by)).SelectedOption.Text;
        }
    }
}
