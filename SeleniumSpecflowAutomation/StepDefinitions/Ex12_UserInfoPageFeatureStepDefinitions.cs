using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AT_FinalAssignment_Project_KailashThakkar.StepDefinitions
{
    [Binding]
    public class Ex12_UserInfoPageFeatureStepDefinitions
    {
        IWebDriver driver;
        string url = "https://demo.nopcommerce.com/";

        [Given(@"chrome browser is open\.\.")]
        public void GivenChromeBrowserIsOpen_()
        {
            //Launching the chrome browser
            driver = new ChromeDriver(".");
            driver.Manage().Window.Maximize();
        }

        [Given(@"the app is opened\.\.")]
        public void GivenTheAppIsOpened_()
        {
            //Launching the app
            driver.Url = url;
        }

        [When(@"user click on login link")]
        public void WhenUserClickOnLoginLink()
        {
            //Validating log in link with assertion
            IWebElement loginLink = driver.FindElement(By.LinkText("Log in"));
            Assert.IsTrue(loginLink.Enabled);
            Console.WriteLine("login link enabled = " + loginLink.Enabled);
            loginLink.Click();
        }

        [Then(@"app show login page")]
        public void ThenAppShowLoginPage()
        {
            //Validating page title with assertion
            string expectedTitle = "nopCommerce demo store. Login";
            string actualTitle = driver.Title;
            Assert.AreEqual(expectedTitle, actualTitle);
            Console.WriteLine(actualTitle);
            Thread.Sleep(2000);
        }

        [When(@"user enter ""([^""]*)"" in email field")]
        public void WhenUserEnterInEmailField(string p0)
        {

            IWebElement emailField = driver.FindElement(By.Id("Email"));
            emailField.SendKeys(p0);
        }

        [When(@"user enter ""([^""]*)"" in a password field")]
        public void WhenUserEnterInAPasswordField(string p0)
        {
            IWebElement passwordField = driver.FindElement(By.Id("Password"));
            passwordField.SendKeys(p0);
        }

        [When(@"user click on login in button")]
        public void WhenUserClickOnLoginInButton()
        {
            //Validating login button
            IWebElement logInButton = driver.FindElement(By.XPath("(//button[@type='submit'])[2]"));
            Assert.IsTrue(logInButton.Enabled);
            Console.WriteLine("Login button enabled = " + logInButton.Enabled);
            logInButton.Click();
            Thread.Sleep(1000);
        }

        [Then(@"the user is loggen in successfully")]
        public void ThenTheUserIsLoggenInSuccessfully()
        {
            //Validating landing page title 
            Console.WriteLine("Landing page is visible");
            string expectedTitle = "nopCommerce demo store";
            string actualTitle = driver.Title;
            Assert.AreEqual(expectedTitle, actualTitle);
            Console.WriteLine(actualTitle);
            Thread.Sleep(1000);
        }

        [When(@"user clicks on the my account link")]
        public void WhenUserClicksOnTheMyAccountLink()
        {
            //Validating my account link
            IWebElement myAccountLink = driver.FindElement(By.ClassName("ico-account"));
            Assert.IsTrue(myAccountLink.Displayed);
            Console.WriteLine("My account link displyed = " + myAccountLink.Displayed);
            myAccountLink.Click();
        }

        [Then(@"user is navigated to my account page")]
        public void ThenUserIsNavigatedToMyAccountPage()
        {
            //Validating my account page title 
            Console.WriteLine("Landing page is visible");
            string expectedTitle = "nopCommerce demo store. Account";
            string actualTitle = driver.Title;
            Assert.AreEqual(expectedTitle, actualTitle);
            Console.WriteLine(actualTitle);
            Thread.Sleep(2000);
            
        }

        [When(@"user clicks on save button")]
        public void WhenUserClicksOnSaveButton()
        {
            IWebElement saveButton = driver.FindElement(By.XPath("//button[@class='button-1 save-customer-info-button']"));
            saveButton.Click();
            Thread.Sleep(2000);
        }

        [Then(@"user's personal info is saved is successfully")]
        public void ThenUsersPersonalInfoIsSavedIsSuccessfully()
        {
            //Validating user info is saved successfully
            IWebElement savedSuccessfully = driver.FindElement(By.XPath("//p[text()='The customer info has been updated successfully.']"));
            Console.WriteLine(savedSuccessfully.Text);
            driver.Quit();
        }

    }
}
