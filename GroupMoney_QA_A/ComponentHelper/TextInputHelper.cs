using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace GroupMoney_QA_A.ComponentHelper
{
    public class TextInputHelper
    {
        public static void SendText(By by, string text)
        {
            GenericHelper.GetWebElement(by).SendKeys(text);
        }
        public static void ClearText(By by)
        {
            GenericHelper.GetWebElement(by).Clear();
        }
    }
}
