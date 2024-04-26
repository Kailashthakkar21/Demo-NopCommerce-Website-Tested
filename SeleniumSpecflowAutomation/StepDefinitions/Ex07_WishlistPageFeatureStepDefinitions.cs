using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AT_FinalAssignment_Project_KailashThakkar.StepDefinitions
{
    [Binding]
    public class Ex07_WishlistPageFeatureStepDefinitions
    {
        IWebDriver driver;
        string url = "https://demo.nopcommerce.com/";

       
        [Given(@"chrome browser is open")]
        public void GivenChromeBrowserIsOpen()
        {
            //Launching the chrome browser
            driver = new ChromeDriver(".");
            driver.Manage().Window.Maximize();
        }

        //Validating wishlist page
        [Given(@"the app is open")]
        public void GivenTheAppIsOpen()
        {
            //Launching the app
            driver.Url = url;
        }
        [When(@"user enters the ""([^""]*)"" in search field")]
        public void WhenUserEntersTheInSearchField(string p0)
        {
            //Validating search field 
            IWebElement searchField = driver.FindElement(By.Id("small-searchterms"));
            Assert.IsTrue(searchField.Enabled);
            Console.WriteLine("Search field enabled = " + searchField.Enabled);
            searchField.SendKeys(p0);
            Thread.Sleep(1000);
        }

        [When(@"user clicks on the search button\.")]
        public void WhenUserClicksOnTheSearchButton_()
        {
             //Validatig search button
            IWebElement searchButton = driver.FindElement(By.XPath("//button[@class='button-1 search-box-button']"));
            Assert.IsTrue(searchButton.Enabled);
            Console.WriteLine("Search button Enabled = " + searchButton.Enabled);
            searchButton.Click();
            Thread.Sleep(1000);
        }

        [When(@"user clicks on the Pride And Prjudice product image link")]
        public void WhenUserClicksOnThePrideAndPrjudiceProductImageLink()
        {
             IWebElement prideAndPrejudiceLink = driver.FindElement(By.XPath("//img[@src='https://demo.nopcommerce.com/images/thumbs/0000070_pride-and-prejudice_415.jpeg']"));
            Assert.IsTrue(prideAndPrejudiceLink.Enabled);
            prideAndPrejudiceLink.Click();
        }

        [Then(@"user is navigated to the pride and prejudice product details page")]
        public void ThenUserIsNavigatedToThePrideAndPrejudiceProductDetailsPage()
        {
            //Validate page tile
            string expectedTitle = "nopCommerce demo store. Pride and Prejudice";
            string actualTitle = driver.Title;
            Console.WriteLine("Page title is " + actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(1000);
              

        }

        [When(@"user clicks on Add to wishlist button on pride and prejudice product details page")]
        public void WhenUserClicksOnAddToWishlistButtonOnPrideAndPrejudiceProductDetailsPage()
        {
            IWebElement wishlistButton = driver.FindElement(By.Id("add-to-wishlist-button-39"));
            wishlistButton.Click();
            Thread.Sleep(2000);
        }

        [Then(@"product is added into the wishlist")]
        public void ThenProductIsAddedIntoTheWishlist()
        {
            IWebElement addedIntoWishlist = driver.FindElement(By.XPath("//p[@class='content']"));
            Console.WriteLine(addedIntoWishlist.Text);
        }

        [When(@"user clicks on wishlist link")]
        public void WhenUserClicksOnWishlistLink()
        {
            IWebElement wishlistLink = driver.FindElement(By.LinkText("Wishlist"));
            wishlistLink.Click();
        }


        [Then(@"user is navigated to wishlist page")]
        public void ThenUserIsNavigatedToWishlistPage()
        {
            //Validate page tile
            string expectedTitle = "nopCommerce demo store. Wishlist";
            string actualTitle = driver.Title;
            Console.WriteLine("Page title is " + actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(1000);
        }

        [When(@"user clicks on add to cart checkbox")]
        public void WhenUserClicksOnAddToCartCheckbox()
        {
            IWebElement addToCartCheckbox = driver.FindElement(By.XPath("//input[@name='addtocart']"));
            addToCartCheckbox.Click();
        }

        [When(@"user clicks on add to cart button")]
        public void WhenUserClicksOnAddToCartButton()
        {
            IWebElement addToCartButton = driver.FindElement(By.XPath("//button[@name='addtocartbutton']"));
            addToCartButton.Click();
        }

        [Then(@"product is added into cart from wishlist page")]
        public void ThenProductIsAddedIntoCartFromWishlistPage()
        {
            //Validating cart count 
            IWebElement cartCount = driver.FindElement(By.XPath("//span[@class='cart-qty']"));
            string expectedCount = "(1)";
            string actualCount = cartCount.Text;
            Assert.AreEqual(expectedCount, actualCount);
            Console.WriteLine(actualCount);
            Thread.Sleep(1000);
            driver.Quit();
        }

        //Validating wishlist with invalid data
        [When(@"user enters the ""([^""]*)"" in qty field")]
        public void WhenUserEntersTheInQtyField(string p0)
        {
            IWebElement qtyField = driver.FindElement(By.ClassName("qty-input"));
            qtyField.Clear();
            Thread.Sleep(1000);
            qtyField.SendKeys(p0);
        }


        [When(@"user clicks on update button")]
        public void WhenUserClicksOnUpdateButton()
        {
            IWebElement UpdateWishlistButton = driver.FindElement(By.XPath("(//button[@name='updatecart'])[2]"));
            UpdateWishlistButton.Click();
        }

        [Then(@"wishlist is not updated")]
        public void ThenWishlistIsNotUpdated()
        {
            IWebElement wishlistInvalid = driver.FindElement(By.XPath("//li[text()='This product is required in the quantity of 0']"));
            Console.WriteLine(wishlistInvalid.Text);
            Thread.Sleep(1000);
            driver.Quit();
        }
    }
}
