using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AT_FinalAssignment_Project_KailashThakkar.StepDefinitions
{
    [Binding]
    public class Ex01_LandingPageFeatureStepDefinitions
    {
        IWebDriver driver;
        string url = "https://demo.nopcommerce.com/";

        [Given(@"Chrome browser is open\.")]
        public void GivenChromeBrowserIsOpen_()
        {
            //Laucnhig the chrome browser
            driver = new ChromeDriver(".");
            driver.Manage().Window.Maximize();
        }

        [Given(@"app is opened\.")]
        public void GivenAppIsOpened_()
        {
            //Launching the app
            driver.Url = url;   
        }

        [Then(@"app shows landing page")]
        public void ThenAppShowsLandingPage()
        {
            
            //Validating landing page title 
            Console.WriteLine("Landing page is visible");
            string expectedTitle = "nopCommerce demo store";
            string actualTitle = driver.Title;
            Assert.AreEqual(expectedTitle, actualTitle);
            Console.WriteLine(actualTitle);
            Thread.Sleep(2000);
            
        }

        [When(@"user clicks on Register link")]
        public void WhenUserClicksOnRegisterLink()
        {
            //Validating register link with asssertion
            IWebElement registerLink = driver.FindElement(By.LinkText("Register"));
            Assert.IsTrue(registerLink.Enabled);
            Console.WriteLine("Register link enabled = " + registerLink.Enabled);
            registerLink.Click();
        }

        [Then(@"user navigates to Register page")]
        public void ThenUserNavigatesToRegisterPage()
        {
            //Validating register page title with assertion
            string expectedTitle = "nopCommerce demo store. Register";
            string actualTitle = driver.Title;
            Assert.AreEqual(expectedTitle, actualTitle);
            Console.WriteLine(actualTitle);
            Thread.Sleep(2000);
            driver.Navigate().Back();
            driver.Quit();

        }
        [When(@"user clicks on Log in link")]
        public void WhenUserClicksOnLogInLink()
        {
            //Validating log in link with assertion
            IWebElement loginLink = driver.FindElement(By.LinkText("Log in"));
            Assert.IsTrue(loginLink.Enabled);
            Console.WriteLine("login link enabled = " + loginLink.Enabled);
            loginLink.Click();
        }

        [Then(@"user navigates to Log in page\.")]
        public void ThenUserNavigatesToLogInPage_()
        {
            //Validating log in page title 
            Console.WriteLine("App shows login page");
            string expectedTitle = "nopCommerce demo store. Login";
            string actualTitle = driver.Title;
            Assert.AreEqual(expectedTitle, actualTitle);
            Console.WriteLine(actualTitle);
            Thread.Sleep(1000);
            driver.Navigate().Back();
            Thread.Sleep(1000);
            driver.Quit();
        }
    }
}
