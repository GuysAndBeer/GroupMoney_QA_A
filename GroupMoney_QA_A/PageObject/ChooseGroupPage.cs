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
    [Alias("Choose Group")]
    public class ChooseGroupPage : PageBase
    {
        [Alias("Create New Group")]
        public CustomWebElement ChooseGroupButton = new CustomWebElement(By.ClassName("green"));
        [Alias("Group Name")]
        public CustomWebElement GroupInput = new CustomWebElement(By.CssSelector("input.new_group_input"));

    }
}
