using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AT_FinalAssignment_Project_KailashThakkar.StepDefinitions
{
    [Binding]
    public class Ex06_ProductDetailsPageStepDefinitions
    {
        IWebDriver driver;
        string url = "https://demo.nopcommerce.com/";

        [Given(@"chrome browser is opened")]
        public void GivenChromeBrowserIsOpened()
        {
            //Launching the chrome browser
            driver = new ChromeDriver(".");
            driver.Manage().Window.Maximize();
        }

        [Given(@"the app is opened")]
        public void GivenTheAppIsOpened()
        {
            //Launching the app
            driver.Url = url;
        }

        [When(@"user enters ""([^""]*)"" in search field")]
        public void WhenUserEntersInSearchField(string p0)
        {
            //Validating search field 
            IWebElement searchField = driver.FindElement(By.Id("small-searchterms"));
            Assert.IsTrue(searchField.Enabled);
            Console.WriteLine("Search field enabled = " + searchField.Enabled);
            searchField.SendKeys(p0);
            Thread.Sleep(1000);
        }

        [When(@"user clicks on search button\.")]
        public void WhenUserClicksOnSearchButton_()
        {
            //Validatig search button
            IWebElement searchButton = driver.FindElement(By.XPath("//button[@class='button-1 search-box-button']"));
            Assert.IsTrue(searchButton.Enabled);
            Console.WriteLine("Search button Enabled = " + searchButton.Enabled);
            searchButton.Click();
            Thread.Sleep(1000);
        }

        [When(@"user clicks on Pride And Prjudice product image link")]
        public void WhenUserClicksOnPrideAndPrjudiceProductImageLink()
        {
            IWebElement prideAndPrejudiceLink = driver.FindElement(By.XPath("//img[@src='https://demo.nopcommerce.com/images/thumbs/0000070_pride-and-prejudice_415.jpeg']"));
            Assert.IsTrue(prideAndPrejudiceLink.Enabled);
            prideAndPrejudiceLink.Click();
        }


        [Then(@"user is navigated to pride and prejudice product details")]
        public void ThenUserIsNavigatedToPrideAndPrejudiceProductDetails()
        {
            //Validate page tile
            string expectedTitle = "nopCommerce demo store. Pride and Prejudice";
            string actualTitle = driver.Title;
            Console.WriteLine("Page title is " + actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(1000);
            
        }

        [When(@"user clicks on Add to cart button on pride and prejudice product details page")]
        public void WhenUserClicksOnAddToCartButtonOnPrideAndPrejudiceProductDetailsPage()
        {
            //Validating add to cart button
            IWebElement addToCartButton = driver.FindElement(By.XPath("(//button[@data-productid='39'])[1]"));
            Assert.IsTrue(addToCartButton.Enabled);
            addToCartButton.Click();
            Thread.Sleep(2000);
        }

        [Then(@"pride and prejudice product is added into the cart\.")]
        public void ThenPrideAndPrejudiceProductIsAddedIntoTheCart_()
        {
            //Validating cart count 
            IWebElement cartCount = driver.FindElement(By.XPath("//span[@class='cart-qty']"));
            string expectedCount = "(1)";
            string actualCount = cartCount.Text;
            Assert.AreEqual(expectedCount, actualCount);
            Console.WriteLine(actualCount);
            Thread.Sleep(1000);
            
        }

        [When(@"user enter ""([^""]*)"" the quantity fied of Pride And Prjudice product")]
        public void WhenUserEnterTheQuantityFiedOfPrideAndPrjudiceProduct(string p0)
        {
            IWebElement qtyField = driver.FindElement(By.Id("product_enteredQuantity_39"));
            qtyField.Clear();
            qtyField.SendKeys(p0);
            Thread.Sleep(1000);
        }

        [Then(@"pride and prejudice product is not added into the cart\.")]
        public void ThenPrideAndPrejudiceProductIsNotAddedIntoTheCart_()
        {
            IWebElement qtyInavlid = driver.FindElement(By.XPath("//p[text()='Quantity should be positive']"));
            Console.WriteLine(qtyInavlid.Text);
            Thread.Sleep(1000);
            driver.Quit();
        }
    }
}
