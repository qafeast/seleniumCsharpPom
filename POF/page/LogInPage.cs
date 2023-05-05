using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using SeleniumExtras.WaitHelpers;

namespace seleniumCsharpPom.POF.page
{
    public class LogInPage
    {
        IWebDriver driver;
        public LogInPage(IWebDriver driver) { 
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.CssSelector, Using = "input[name='userName']")]
        private IWebElement _userName;

        [FindsBy(How = How.CssSelector, Using = "input[name='password']")]
        private IWebElement _password;

        [FindsBy(How = How.CssSelector, Using = "input[name='submit']")]
        private IWebElement _submit;

        public void LogInActions(string username, string password)
        {
            _userName.SendKeys(username);
            _password.SendKeys(password);
            _submit.Click();
        }
        
        public void VerifyLogInSuccess()
        {
            bool waitForHomePage = new WebDriverWait(driver, TimeSpan.FromSeconds(10))
                    .Until(ExpectedConditions.UrlContains("login_sucess.php"));
            Assert.True(waitForHomePage, "Successfully Logged in");
        }
    }
}
