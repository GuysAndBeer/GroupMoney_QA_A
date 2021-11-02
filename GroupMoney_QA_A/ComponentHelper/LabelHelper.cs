using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace GroupMoney_QA_A.ComponentHelper
{
    public class LabelHelper
    {
        public static bool IsTextEquals(By by, string text)
        {
            return GenericHelper.GetWebElement(by).Text.Equals(text);
        }
    }
}
