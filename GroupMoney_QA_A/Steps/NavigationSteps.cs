using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using GroupMoney_QA_A.ComponentHelper;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechTalk.SpecFlow;

namespace GroupMoney_QA_A.Steps
{
    [Binding]
    public sealed class NavigationSteps
    {
        [Given(@"Open the '(.*)' page")]
        [When(@"Open the '(.*)' page")]
        public void GivenOpenThePage(string page)
        {
            NavigationHelper.NavigateToUrl(NavigationHelper.GetTheUrl(page));
        }

        [Then(@"The '(.*)' page is opened")]
        public void ThenThePageIsOpened(string page)
        {
            Thread.Sleep(500);
            Assert.AreEqual(page, NavigationHelper.GetThePageTitle());
        }

    }
}
