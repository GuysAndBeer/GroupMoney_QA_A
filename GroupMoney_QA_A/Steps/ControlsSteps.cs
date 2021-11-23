using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using GroupMoney_QA_A.ComponentHelper;
using GroupMoney_QA_A.Factories;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TechTalk.SpecFlow;

namespace GroupMoney_QA_A.Steps
{
    [Binding]
    public sealed class ControlsSteps
    {
        [When(@"Set '(.*)' text value to '(.*)' text input on '(.*)'")]
        public void WhenSetTextValueToTextInputOn(string value, string inputName, string pageName)
        {
            var textInput = PagesFactory.GetElement(inputName, PagesFactory.GetPage(pageName));
            TextInputHelper.SendText(textInput.Locator, value);
        }

        [When(@"Click '(.*)' button on '(.*)'")]
        public void WhenClickButtonOn(string buttonName, string pageName)
        {
            var button = PagesFactory.GetElement(buttonName, PagesFactory.GetPage(pageName));
            ButtonHelper.ClickTheButton(button.Locator);
        }

        [Then(@"Text value of '(.*)' label on '(.*)' is '(.*)'")]
        public void ThenTextValueOfLabelOnIs(string labelName, string pageName, string value)
        {
            var label = PagesFactory.GetElement(labelName, PagesFactory.GetPage(pageName));
            Assert.IsTrue(LabelHelper.IsTextEquals(label.Locator, value), 
                $"{labelName} label value is not {value}");
        }

        [When(@"Click button with '(.*)' text on '(.*)'")]
        public void WhenClickButtonWithTextOn(string buttonName, string pageName)
        {
            
            //ButtonHelper.ClickTheButton(By.);
        }

        [Then(@"'(.*)' grid contains '(.*)' text value")]
        public void ThenGridContainsTextValue(string p0, string p1)
        {
            ScenarioContext.Current.Pending();
            
        }


    }
}
