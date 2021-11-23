using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GroupMoney_QA_A.Attributes;
using GroupMoney_QA_A.BaseClasses;
using OpenQA.Selenium;

namespace GroupMoney_QA_A.PageObject
{
    [Alias("Main")]
    class MainPage : PageBase
    {
        [Alias("Username")]
        public CustomWebElement UsernameLabel = new CustomWebElement(By.ClassName("budget-title"));
        [Alias("Sign Out")]
        public CustomWebElement SignOutButton = new CustomWebElement(By.CssSelector("nav#authorisation a.nav__link"));
        [Alias("Budget Money")]
        public CustomWebElement BudgetMoneyLabel = new CustomWebElement(By.CssSelector(".budget-value"));
        [Alias("Budget Income")]
        public CustomWebElement BudgetIncomeLabel = new CustomWebElement(By.CssSelector(".budget-income-value"));
        [Alias("Budget Debts")]
        public CustomWebElement BudgetDebtsLabel = new CustomWebElement(By.CssSelector(".budget-expenses-value"));
        [Alias("Choose group")]
        public CustomWebElement ChooseGroupButton = new CustomWebElement(By.CssSelector("a.choose_group"));

        #region Tabs
        [Alias("Expenses")]
        public CustomWebElement ExpensesButton = new CustomWebElement(By.CssSelector("span.tab_name"));
        [Alias("Debts")]
        public CustomWebElement DebtsButton = new CustomWebElement(By.CssSelector("span.tab_name2"));
        [Alias("Members")]
        public CustomWebElement MembersButton = new CustomWebElement(By.CssSelector("span.tab_name3"));
        [Alias("Activity")]
        public CustomWebElement ActivityButton = new CustomWebElement(By.CssSelector("span.tab_name4"));

        #endregion

        #region Expenses

        /*[Alias("Expenses")]
        public CustomWebElement ExpensesButton = new CustomWebElement(By.CssSelector("span.tab_name"));*/

        #endregion

        #region Debts

        /*[Alias("Expenses")]
        public CustomWebElement ExpensesButton = new CustomWebElement(By.CssSelector("span.tab_name"));*/

        #endregion

        #region Members

        [Alias("Add Member")]
        public CustomWebElement AddMemberButton = new CustomWebElement(By.CssSelector(".add_member"));
        [Alias("New User Name")]
        public CustomWebElement NewUserNamerButton = new CustomWebElement(By.CssSelector(".name_input"));
        [Alias("Save")]
        public CustomWebElement SaveButton = new CustomWebElement(By.CssSelector(".save"));

        #endregion

        #region Activity

        //[Alias("Expenses")]
        //public CustomWebElement ExpensesButton = new CustomWebElement(By.CssSelector("span.tab_name"));

        #endregion

        #region Create Expense Dialog

        //[Alias("Expenses")]
        //public CustomWebElement ExpensesButton = new CustomWebElement(By.CssSelector("span.tab_name"));

        #endregion

    }
}
