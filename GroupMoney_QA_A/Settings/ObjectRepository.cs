using GroupMoney_QA_A.Interfaces;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupMoney_QA_A.Settings
{
    class ObjectRepository
    {
        public static IWebDriver WebDriver { get; set; }
        public static IConfig Configuration { get; set; }

    }
}
