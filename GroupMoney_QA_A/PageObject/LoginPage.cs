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
    [Alias("Login")]
    class LoginPage : PageBase
    {
        [Alias("Login")]
        public CustomWebElement LoginTextInput = new CustomWebElement(By.CssSelector("input.firebaseui-id-email"));
        [Alias("Action")]
        public CustomWebElement UsernameLabel = new CustomWebElement(By.CssSelector("h1.firebaseui-title"));
        [Alias("Password")]
        public CustomWebElement PasswordTextInput = new CustomWebElement(By.CssSelector("input.firebaseui-id-new-password"));
        [Alias("Full name")]
        public CustomWebElement UsernameTextInput = new CustomWebElement(By.CssSelector("input.firebaseui-id-name"));
        [Alias("Next")]
        public CustomWebElement NextButton = new CustomWebElement(By.CssSelector("button.firebaseui-id-submit"));
        [Alias("Sign In")]
        public CustomWebElement SignInButton = new CustomWebElement(By.CssSelector("button.firebaseui-id-submit"));
        [Alias("Back")]
        public CustomWebElement LogInButton = new CustomWebElement(By.CssSelector("button.firebaseui-id-secondary-link"));
    }
}
