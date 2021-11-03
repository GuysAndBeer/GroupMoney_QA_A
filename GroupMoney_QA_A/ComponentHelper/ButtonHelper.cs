using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace GroupMoney_QA_A.ComponentHelper
{
    public class ButtonHelper
    {
        public static void ClickTheButton(By by)
        {
            GenericHelper.GetWebElement(by).Click();
        }
    }
}
