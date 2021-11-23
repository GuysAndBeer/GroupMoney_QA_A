using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupMoney_QA_A.Attributes;
using GroupMoney_QA_A.BaseClasses;
using GroupMoney_QA_A.Settings;
using OpenQA.Selenium;

namespace GroupMoney_QA_A.PageObject
{
    [Alias("Home")]
    public class HomePage : PageBase
    {
        [Alias("Sign In")] 
        public CustomWebElement LogInButton = new CustomWebElement(By.CssSelector("a.info-login"));

    }
}
