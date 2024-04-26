using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Threading;
using TechTalk.SpecFlow;

namespace AT_FinalAssignment_Project_KailashThakkar.StepDefinitions
{
    [Binding]
    public class Ex08_AddToCartPageFeatureStepDefinitions
    {
        IWebDriver driver;
        string url = "https://demo.nopcommerce.com/";

        [Given(@"the chrome browser is opened")]
        public void GivenTheChromeBrowserIsOpened()
        {
            //Launching the chrome browser
            driver = new ChromeDriver(".");
            driver.Manage().Window.Maximize();
        }

        [Given(@"app is open")]
        public void GivenAppIsOpen()
        {
            //Launching the app
            driver.Url = url;
        }

        [When(@"user enters ""([^""]*)"" in the search field")]
        public void WhenUserEntersInTheSearchField(string p0)
        {
            //Validating search field 
            IWebElement searchField = driver.FindElement(By.Id("small-searchterms"));
            Assert.IsTrue(searchField.Enabled);
            Console.WriteLine("Search field enabled = " + searchField.Enabled);
            searchField.SendKeys(p0);
            Thread.Sleep(1000);
        }

        [When(@"user clicks search button\.")]
        public void WhenUserClicksSearchButton_()
        {
            //Validatig search button
            IWebElement searchButton = driver.FindElement(By.XPath("//button[@class='button-1 search-box-button']"));
            Assert.IsTrue(searchButton.Enabled);
            Console.WriteLine("Search button Enabled = " + searchButton.Enabled);
            searchButton.Click();
            Thread.Sleep(1000);
        }

        [When(@"user clicks Pride And Prjudice product image link")]
        public void WhenUserClicksPrideAndPrjudiceProductImageLink()
        {
            IWebElement prideAndPrejudiceLink = driver.FindElement(By.XPath("//img[@src='https://demo.nopcommerce.com/images/thumbs/0000070_pride-and-prejudice_415.jpeg']"));
            Assert.IsTrue(prideAndPrejudiceLink.Enabled);
            prideAndPrejudiceLink.Click();
        }

        [Then(@"user is navigated to the pride and prejudice product details")]
        public void ThenUserIsNavigatedToThePrideAndPrejudiceProductDetails()
        {
            //Validate page tile
            string expectedTitle = "nopCommerce demo store. Pride and Prejudice";
            string actualTitle = driver.Title;
            Console.WriteLine("Page title is " + actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(1000);

        }

        [When(@"user clicks on the Add to cart button on pride and prejudice product details page")]
        public void WhenUserClicksOnTheAddToCartButtonOnPrideAndPrejudiceProductDetailsPage()
        {
            //Validating add to cart button
            IWebElement addToCartButton = driver.FindElement(By.XPath("(//button[@data-productid='39'])[1]"));
            Assert.IsTrue(addToCartButton.Enabled);
            addToCartButton.Click();
            Thread.Sleep(2000);
        }

        [Then(@"pride and prejudice product is added into cart\.")]
        public void ThenPrideAndPrejudiceProductIsAddedIntoCart_()
        {
            //Validating cart count 
            IWebElement cartCount = driver.FindElement(By.XPath("//span[@class='cart-qty']"));
            string expectedCount = "(1)";
            string actualCount = cartCount.Text;
            Assert.AreEqual(expectedCount, actualCount);
            Console.WriteLine(actualCount);
            Thread.Sleep(1000);
        }
        [When(@"user clicks on theshopping cart link")]
        public void WhenUserClicksOnTheshoppingCartLink()
        {
            //Validating shopping cart link
            IWebElement cartLink = driver.FindElement(By.LinkText("Shopping cart"));
            Assert.IsTrue(cartLink.Enabled);
            cartLink.Click();
            Thread.Sleep(2000);
        }

        [Then(@"user is navigated to the shopping cart page")]
        public void ThenUserIsNavigatedToTheShoppingCartPage()
        {
            //Validating page title
            string expectedTitle = "nopCommerce demo store. Shopping Cart";
            string actualTitle = driver.Title;
            Console.WriteLine("Page title is " + actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(1000);
        }

        [When(@"user clicks on terms and condition checkbox")]
        public void WhenUserClicksOnTermsAndConditionCheckbox()
        {
            //Validating terms and condition checkbox
            IWebElement termsAndConditionCheckbox = driver.FindElement(By.XPath("//input[@id='termsofservice']"));
            termsAndConditionCheckbox.Click();
            Thread.Sleep(1000);
           

        }

        [When(@"user clicks on the checkout button")]
        public void WhenUserClicksOnTheCheckoutButton()
        {
            //Validating checkout button
            IWebElement checkoutButton = driver.FindElement(By.XPath("//button[@id='checkout']"));
            Assert.IsTrue(checkoutButton.Enabled);
            checkoutButton.Click();
            Thread.Sleep(2000);
        }

        [Then(@"user is navigated to checkout page\.")]
        public void ThenUserIsNavigatedToCheckoutPage_()
        {
            IWebElement checkoutAsGuestButton = driver.FindElement(By.XPath("//button[text()='Checkout as Guest']"));
            checkoutAsGuestButton.Click();  
            Thread.Sleep(1000);
            //Validating page title
            string expectedTitle = "nopCommerce demo store. Checkout";
            string actualTitle = driver.Title;
            Console.WriteLine("Page title is " + actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(1000);
            driver.Quit();  
        }

        //Validating shopping cart keeping quantity field negtaive
        [When(@"user enters ""([^""]*)"" in the qty field")]
        public void WhenUserEntersInTheQtyField(string p0)
        {
            IWebElement qtyInvalid = driver.FindElement(By.XPath("//input[@class='qty-input']"));
            qtyInvalid.Clear();
            Thread.Sleep(1000);
            qtyInvalid.SendKeys(p0);
        }

        [When(@"user clicks update cart button")]
        public void WhenUserClicksUpdateCartButton()
        {
            IWebElement updateShoppingCartButton = driver.FindElement(By.XPath("(//button[@name='updatecart'])[2]"));
           updateShoppingCartButton.Click();
        }

        [Then(@"shopping cart is not updated")]
        public void ThenShoppingCartIsNotUpdated()
        {
            //Validating invalid message
            IWebElement cartInvalid = driver.FindElement(By.XPath("//li[text()='This product is required in the quantity of 0']"));
            Console.WriteLine(cartInvalid.Text);    
            Thread.Sleep(1000);
            driver.Quit();

           
        }
    }
}
