using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace GroupMoney_QA_A.ComponentHelper
{
    public class LabelHelper
    {
        public static bool IsTextEquals(By by, string text)
        {
            Thread.Sleep(1000);
            string labelText = GenericHelper.GetWebElement(by).Text;
            return labelText.Equals(text);
        }
    }
}
