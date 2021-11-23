using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace GroupMoney_QA_A.BaseClasses
{
    public class CustomWebElement
    {
        public CustomWebElement(By by)
        {
            Locator = by;
        }

        public By Locator { get; set; }
    }
}
