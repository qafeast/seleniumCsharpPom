using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumCsharpPom.POM.page
{
    public class LogInPage
    {
        IWebDriver driver;
        public LogInPage(IWebDriver driver)
        {

            this.driver = driver;
        }

        public void EnterUserName()
        {
            driver.FindElement(By.CssSelector("input[name='userName']")).SendKeys("admin");
        }
        public void EnterPassword()
        {
            driver.FindElement(By.CssSelector("input[name='password']")).SendKeys("admin");
        }
        public void ClickLogInButton()
        {
            driver.FindElement(By.CssSelector("input[name='submit']")).Click();
        }
        public void VerifyLogInSuccess()
        {
            bool waitForHomePage = new WebDriverWait(driver, TimeSpan.FromSeconds(10))
                    .Until(ExpectedConditions.UrlContains("login_sucess.php"));
            Assert.True(waitForHomePage, "Successfully Logged in");
        }
    }
}
