using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AT_FinalAssignment_Project_KailashThakkar.StepDefinitions
{
    [Binding]
    public class Ex04_HomePageFeatureStepDefinitions
    {
        IWebDriver driver;
        string url = "https://demo.nopcommerce.com/";

        [Given(@"chrome browser is launched\.")]
        public void GivenChromeBrowserIsLaunched_()
        {
            //Launching the chrome browser
            driver = new ChromeDriver(".");
            driver.Manage().Window.Maximize();
        }

        [Given(@"the app is launched\.")]
        public void GivenTheAppIsLaunched_()
        {
            //Launching the app
            driver.Url = url;
        }

        [When(@"user clicks on the login link")]
        public void WhenUserClicksOnTheLoginLink()
        {
            //Validating log in link with assertion
            IWebElement loginLink = driver.FindElement(By.LinkText("Log in"));
            Assert.IsTrue(loginLink.Enabled);
            Console.WriteLine("login link enabled = " + loginLink.Enabled);
            loginLink.Click();
        }

        [Then(@"user is navigated to login page")]
        public void ThenUserIsNavigatedToLoginPage()
        {
            //Validating page title with assertion
            string expectedTitle = "nopCommerce demo store. Login";
            string actualTitle = driver.Title;
            Assert.AreEqual(expectedTitle, actualTitle);
            Console.WriteLine(actualTitle);
            Thread.Sleep(2000);
        }

        [When(@"user enters the ""([^""]*)"" in email field")]
        public void WhenUserEntersTheInEmailField(string p0)
        {
            IWebElement emailField = driver.FindElement(By.Id("Email"));
            emailField.SendKeys(p0);
        }

        [When(@"user enters the ""([^""]*)"" in password field")]
        public void WhenUserEntersTheInPasswordField(string p0)
        {
            IWebElement passwordField = driver.FindElement(By.Id("Password"));
            passwordField.SendKeys(p0);
        }

        [When(@"user clicks on login button\.")]
        public void WhenUserClicksOnLoginButton_()
        {
            IWebElement loginButton = driver.FindElement(By.XPath("//button[text()='Log in']"));
            Assert.IsTrue(loginButton.Enabled);
            Console.WriteLine("Login button enabled = " + loginButton.Enabled);
            loginButton.Click();
        }

        [Then(@"user is navigated to Home page")]
        public void ThenUserIsNavigatedToHomePage()
        {
            //Validating home page title 
            Console.WriteLine("Landing page is visible");
            string expectedTitle = "nopCommerce demo store";
            string actualTitle = driver.Title;
            Assert.AreEqual(expectedTitle, actualTitle);
            Console.WriteLine(actualTitle);
            Thread.Sleep(2000);
        }

        [When(@"user clicks on My account link")]
        public void WhenUserClicksOnMyAccountLink()
        {
            //Validating my account link
            IWebElement myAccountLink = driver.FindElement(By.ClassName("ico-account"));
            Assert.IsTrue(myAccountLink.Displayed);
            Console.WriteLine("My account link displyed = " + myAccountLink.Displayed);
            myAccountLink.Click();
            
        }

        [Then(@"user is navigated to my account page\.")]
        public void ThenUserIsNavigatedToMyAccountPage_()
        {
            //Validating my account page title 
            Console.WriteLine("Landing page is visible");
            string expectedTitle = "nopCommerce demo store. Account";
            string actualTitle = driver.Title;
            Assert.AreEqual(expectedTitle, actualTitle);
            Console.WriteLine(actualTitle);
            Thread.Sleep(2000);
            driver.Quit();
        }

        [When(@"user clicks on log out link")]
        public void WhenUserClicksOnLogOutLink()
        {
            //Validating log out link 
            IWebElement logOutLink = driver.FindElement(By.ClassName("ico-logout"));
            Assert.IsTrue(logOutLink.Displayed);
            Console.WriteLine("Log out link is displyed = " + logOutLink.Displayed);
            logOutLink.Click();
            Thread.Sleep(2000);            
        }

        [Then(@"user is logged out successfully\.")]
        public void ThenUserIsLoggedOutSuccessfully_()
        {
            //User is logged out successfullt so now user can log in again
            IWebElement loginLink = driver.FindElement(By.LinkText("Log in"));
            Assert.IsTrue(loginLink.Enabled);
            Console.WriteLine("login link enabled = " + loginLink.Enabled);
            loginLink.Click();
            driver.Quit();
        }
    }
}
