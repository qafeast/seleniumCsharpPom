using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using seleniumCsharpPom.POM.page;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace seleniumCsharpPom.POM.test
{
    public class MercuryTourTest
    {
        IWebDriver driver;


        [SetUp]
        public void SetUp()
        {
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArgument("start-maximized");
            driver = new ChromeDriver(chromeOptions);
            driver.Navigate().GoToUrl("https://demo.guru99.com/test/newtours/");
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(2);
        }

        [Test] 
        public void LogInTest()
        {
            LogInPage logInPage = new LogInPage(driver);
            logInPage.EnterUserName();
            logInPage.EnterPassword();
            logInPage.ClickLogInButton();
            logInPage.VerifyLogInSuccess();
        }
        [TearDown] public void TearDown() => driver.Quit();
    }
}
