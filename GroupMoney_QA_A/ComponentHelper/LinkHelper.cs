using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace GroupMoney_QA_A.ComponentHelper
{
    public class LinkHelper
    {
        public static void ClickTheLink(By by)
        {
            GenericHelper.GetWebElement(by).Click();
        }
    }
}
