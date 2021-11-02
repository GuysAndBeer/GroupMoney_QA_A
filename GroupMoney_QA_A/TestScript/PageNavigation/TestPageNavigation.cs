using GroupMoney_QA_A.ComponentHelper;
using GroupMoney_QA_A.Configuration;
using GroupMoney_QA_A.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace GroupMoney_QA_A.TestScript.PageNavigation
{
    [TestClass]
    public class TestPageNavigation
    {
        [TestMethod]
        public void T01_TestMethod()
        {
             LinkHelper.ClickTheLink(By.XPath("//a[text() = 'Sign Up']"));
             TextInputHelper.SendText(By.CssSelector("input#username"), "Test");
             TextInputHelper.SendText(By.CssSelector("input#login"), "Test");
             TextInputHelper.SendText(By.CssSelector("input#password"), "Test");
             TextInputHelper.SendText(By.CssSelector("input#group_name"), "Test");
             ButtonHelper.ClickTheButton(By.CssSelector("input[type='submit']"));
             GenericHelper.TakeScreenShot();
             Console.WriteLine(WindowHelper.GetTitle());
        }
    }
}
