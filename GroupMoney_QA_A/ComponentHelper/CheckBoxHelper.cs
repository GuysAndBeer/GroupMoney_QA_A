using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace GroupMoney_QA_A.ComponentHelper
{
    public class CheckBoxHelper
    {
        public static void CheckCheckBox(By by)
        {
            GenericHelper.GetWebElement(by).Click();
        }

        public static bool IsCheckBoxChecked(By by)
        {
            var flag = GenericHelper.GetWebElement(by).GetAttribute("checked");
            if (flag == null)
                return false;
            else
                return flag.Equals("true") || flag.Equals("checked");
        }
    }
}
