using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AT_FinalAssignment_Project_KailashThakkar.StepDefinitions
{
    [Binding]
    public class Ex02_RegistrationPageFeatureStepDefinitions
    {
        IWebDriver driver;
        string url = "https://demo.nopcommerce.com/";

        //Scenario:1
        [Given(@"the chrome browser is opened\.")]
        public void GivenTheChromeBrowserIsOpened_()
        {
            //Launching the chrome browser
            driver = new ChromeDriver(".");
            driver.Manage().Window.Maximize();
        }

        [Given(@"the app is open\.")]
        public void GivenTheAppIsOpen_()
        {
            //Launching the app
            driver.Url = url;
        }

        [When(@"user clicks on register link")]
        public void WhenUserClicksOnRegisterLink()
        {
            //Validating register link with asssertion
            IWebElement registerLink = driver.FindElement(By.LinkText("Register"));
            Assert.IsTrue(registerLink.Enabled);
            Console.WriteLine("Register link enabled = " + registerLink.Enabled);
            registerLink.Click();
        }

        [Then(@"app shows registration page")]
        public void ThenAppShowsRegistrationPage()
        {
            //Validating register page title with assertion
            string expectedTitle = "nopCommerce demo store. Register";
            string actualTitle = driver.Title;
            Assert.AreEqual(expectedTitle, actualTitle);
            Console.WriteLine(actualTitle);
            Thread.Sleep(2000);
           
        }
        //Validating registration functionality by passing data in mandatory fields
        [When(@"user enters ""([^""]*)"" in first name field")]
        public void WhenUserEntersInFirstNameField(string kailash)
        {
            
            IWebElement firstNameField = driver.FindElement(By.Id("FirstName"));
            firstNameField.SendKeys(kailash);
        }
      
        [When(@"user enters ""([^""]*)"" in Last name field")]
        public void WhenUserEntersInLastNameField(string thakkar)
        {
            IWebElement lastNameField = driver.FindElement(By.Id("LastName"));
            lastNameField.SendKeys(thakkar);
        }

        [When(@"user enters ""([^""]*)""  in email field")]
        public void WhenUserEntersInEmailField(string p0)
        {
            IWebElement emailField = driver.FindElement(By.Id("Email"));
            emailField.SendKeys(p0);
        }

        [When(@"user enters a ""([^""]*)"" in a password field")]
        public void WhenUserEntersAInAPasswordField(string p0)
        {
            IWebElement passwordField = driver.FindElement(By.XPath("//input[@id='Password']"));
            passwordField.SendKeys(p0);
        }

        [When(@"user enters a ""([^""]*)"" in a confirm password field")]
        public void WhenUserEntersAInAConfirmPasswordField(string p0)
        {
            IWebElement confirmpasswordField = driver.FindElement(By.Id("ConfirmPassword"));
            confirmpasswordField.SendKeys(p0);
        }

        [When(@"user clicks on register button")]
        public void WhenUserClicksOnRegisterButton()
        {
            //Validate register button 
            IWebElement registerButton = driver.FindElement(By.XPath("//button[@id='register-button']"));
            Assert.IsTrue(registerButton.Enabled);
            registerButton.Click();
        }

        [Then(@"user is registered successfully")]
        public void ThenUserIsRegisteredSuccessfully()
        {
            //Validating user registered successfully
            IWebElement registerSuccess = driver.FindElement(By.XPath("//div[@class='result']"));
            Console.WriteLine(registerSuccess.Text);
            driver.Quit();  
        }       
        //Scenario:2
        //Validating registration functionality with invalid email
        [When(@"user enters invalid ""([^""]*)"" in email field")]
        public void WhenUserEntersInvalidInEmailField(string p0)
        {
            IWebElement emailField = driver.FindElement(By.Id("Email"));
            emailField.SendKeys(p0);
        }

        [Then(@"user is not registered successfully")]
        public void ThenUserIsNotRegisteredSuccessfully()
        {
            //Validating user register not successfull
            IWebElement registerInvalid = driver.FindElement(By.Id("Email-error"));
            Console.WriteLine(registerInvalid.Text);    
            Thread.Sleep(1000);
            driver.Quit();
        }
    }
}
