using GroupMoney_QA_A.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupMoney_QA_A.ComponentHelper
{
    public class WindowHelper
    {
        public static string GetTitle()
        {
            return ObjectRepository.WebDriver.Title;
        }
    }
}
