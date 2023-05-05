using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using seleniumCsharpPom.POF.page;

namespace seleniumCsharpPom.POF.test
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
            logInPage.LogInActions("admin", "admin");
            logInPage.VerifyLogInSuccess();
        }
        [TearDown] public void TearDown() => driver.Quit();
    }
}
