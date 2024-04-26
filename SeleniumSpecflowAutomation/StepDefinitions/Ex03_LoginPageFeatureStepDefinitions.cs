using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AT_FinalAssignment_Project_KailashThakkar.StepDefinitions
{
    [Binding]
    public class Ex03_LoginPageFeatureStepDefinitions
    {
        IWebDriver driver;
        string url = "https://demo.nopcommerce.com/";

        [Given(@"the chrome browser is open\.")]
        public void GivenTheChromeBrowserIsOpen_()
        {
            //Launching the chrome browser
            driver = new ChromeDriver(".");
            driver.Manage().Window.Maximize();
        }

        [Given(@"app is open\.")]
        public void GivenAppIsOpen_()
        {
            //Launching the app
            driver.Url = url;
        }

        [When(@"user clicks on login link")]
        public void WhenUserClicksOnLoginLink()
        {
            //Validating log in link with assertion
            IWebElement loginLink = driver.FindElement(By.LinkText("Log in"));
            Assert.IsTrue(loginLink.Enabled);
            Console.WriteLine("login link enabled = " + loginLink.Enabled);
            loginLink.Click();
        }

        [Then(@"apps show login page")]
        public void ThenAppsShowLoginPage()
        {
            //Validating page title with assertion
            string expectedTitle = "nopCommerce demo store. Login";
            string actualTitle = driver.Title;
            Assert.AreEqual(expectedTitle, actualTitle);
            Console.WriteLine(actualTitle);
            Thread.Sleep(2000);
        }

        //Validating log in functionality with valid data
        [When(@"user enters ""([^""]*)"" in email field")]
        public void WhenUserEntersInEmailField(string p0)
        {
            IWebElement emailField = driver.FindElement(By.Id("Email"));
            emailField.SendKeys(p0);
        }

        [When(@"user enters ""([^""]*)"" in a password field")]
        public void WhenUserEntersInAPasswordField(string p0)
        {
            IWebElement passwordField = driver.FindElement(By.Id("Password"));
            passwordField.SendKeys(p0);
        }

        [When(@"user clicks on login in button")]
        public void WhenUserClicksOnLoginInButton()
        {
            //Validating login button
            IWebElement loginButton = driver.FindElement(By.XPath("//button[text()='Log in']"));
            Assert.IsTrue(loginButton.Enabled);
            Console.WriteLine("Login button enabled = " + loginButton.Enabled);
            loginButton.Click();
        }

        [Then(@"user is loggen in successfully")]
        public void ThenUserIsLoggenInSuccessfully()
        {
            //Validating landing page title 
            Console.WriteLine("Landing page is visible");
            string expectedTitle = "nopCommerce demo store";
            string actualTitle = driver.Title;
            Assert.AreEqual(expectedTitle, actualTitle);
            Console.WriteLine(actualTitle);
            Thread.Sleep(2000);
            driver.Quit();

        }

        //Validating login functionality with invalid data
        [When(@"user enters invalid ""([^""]*)"" in a password field")]
        public void WhenUserEntersInvalidInAPasswordField(string p0)
        {
            IWebElement passwordField = driver.FindElement(By.Id("Password"));
            passwordField.SendKeys(p0);
        }

        [Then(@"user is not able to log in successfully")]
        public void ThenUserIsNotAbleToLogInSuccessfully()
        {
            IWebElement loginInvalid = driver.FindElement(By.XPath("//div[text()='Login was unsuccessful. Please correct the errors and try again.']"));
            Console.WriteLine(loginInvalid.Text);
            Thread.Sleep(2000);
            driver.Quit();
        }
    }
}
