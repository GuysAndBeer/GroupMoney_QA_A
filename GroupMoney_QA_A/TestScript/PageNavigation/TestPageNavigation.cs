using GroupMoney_QA_A.ComponentHelper;
using GroupMoney_QA_A.Configuration;
using GroupMoney_QA_A.Interfaces;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupMoney_QA_A.TestScript.PageNavigation
{
    [TestClass]
    public class TestPageNavigation
    {
        [TestMethod]
        public void T01_TestMethod()
        {
            
             Console.WriteLine(WindowHelper.GetTitle());
        }
    }
}
