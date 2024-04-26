using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AT_FinalAssignment_Project_KailashThakkar.StepDefinitions
{
    [Binding]
    public class Ex05_SearchProductPageStepDefinitions
    {
        IWebDriver driver;
        string url = "https://demo.nopcommerce.com/";

        [Given(@"chrome browser is open\.")]
        public void GivenChromeBrowserIsOpen_()
        {
            //Launching the chrome browser
            driver = new ChromeDriver(".");
            driver.Manage().Window.Maximize();
        }

        [Given(@"app is opened")]
        public void GivenAppIsOpened()
        {
            //Launching the app
            driver.Url = url;
        }

        //Validating search functionality with valid data
        [When(@"user enters a ""([^""]*)"" in search field\.")]
        public void WhenUserEntersAInSearchField_(string p0)
        {
            //Validating search field 
            IWebElement searchField = driver.FindElement(By.Id("small-searchterms"));
            Assert.IsTrue(searchField.Enabled);
            Console.WriteLine("Search field enabled = " + searchField.Enabled);
            searchField.SendKeys("Pride and Prejudice");
            Thread.Sleep(1000);
        }


        [When(@"clicks on Search button")]
        public void WhenClicksOnSearchButton()
        {
            //Validatig search button
            IWebElement searchButton = driver.FindElement(By.XPath("//button[@class='button-1 search-box-button']"));
            Assert.IsTrue(searchButton.Enabled);
            Console.WriteLine("Search button Enabled = " + searchButton.Enabled);
            searchButton.Click();
            Thread.Sleep(1000);
            
        }

        [Then(@"user is able to search for product successfully\.")]
        public void ThenUserIsAbleToSearchForProductSuccessfully_()
        {
            IWebElement prideAndPrejudiceLink = driver.FindElement(By.XPath("//img[@src='https://demo.nopcommerce.com/images/thumbs/0000070_pride-and-prejudice_415.jpeg']"));
            Assert.IsTrue(prideAndPrejudiceLink.Enabled);
            prideAndPrejudiceLink.Click();
            //Validate page tile
            string expectedTitle = "nopCommerce demo store. Pride and Prejudice";
            string actualTitle = driver.Title;
            Console.WriteLine("Page title is " + actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(1000);
           driver.Quit();
        }
        //Validating search functionality with invalid data
        [When(@"user enters a invalid ""([^""]*)"" in search field")]
        public void WhenUserEntersAInvalidInSearchField(string hP)
        {
            IWebElement searchField = driver.FindElement(By.Id("small-searchterms"));
            Assert.IsTrue(searchField.Enabled);
            Console.WriteLine("Search field enabled = " + searchField.Enabled);
            searchField.SendKeys(hP);
            Thread.Sleep(1000);
        }


        [Then(@"user is not able to search for HP product\.")]
        public void ThenUserIsNotAbleToSearchForHPProduct_()
        {
            IWebElement searchInvalid = driver.FindElement(By.ClassName("warning"));
            Console.WriteLine(searchInvalid.Text);
            Thread.Sleep(1000);
            driver.Quit();
        }
    }
}
