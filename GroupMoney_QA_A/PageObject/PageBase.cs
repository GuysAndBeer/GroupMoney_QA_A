using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupMoney_QA_A.Settings;
using OpenQA.Selenium;

namespace GroupMoney_QA_A.PageObject
{
    public class PageBase
    {
        protected IWebDriver driver;
        public PageBase()
        {
            driver = ObjectRepository.WebDriver; 
        }
    }
}
