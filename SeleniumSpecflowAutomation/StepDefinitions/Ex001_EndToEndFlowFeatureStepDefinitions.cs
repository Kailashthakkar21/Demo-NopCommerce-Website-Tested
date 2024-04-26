using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace AT_FinalAssignment_Project_KailashThakkar.StepDefinitions
{
    [Binding]
    public class Ex001_EndToEndFlowFeatureStepDefinitions
    {
        IWebDriver driver;
        string url = "https://demo.nopcommerce.com/";

        [Given(@"chrome browser is opened\.")]
        public void GivenChromeBrowserIsOpened_()
        {
            //Launching the browser
            driver = new ChromeDriver(".");
            driver.Manage().Window.Maximize();
        }

        [Given(@"the app is opened\.")]
        public void GivenTheAppIsOpened_()
        {
            //Launching the app 
            driver.Url = url;
        }

        [When(@"user clicks on log in link")]
        public void WhenUserClicksOnLogInLink()
        {
            //Validating login link and naviagting to login page
            IWebElement loginLink = driver.FindElement(By.ClassName("ico-login"));
            Assert.IsTrue(loginLink.Enabled);
            Console.WriteLine("Login link displayed = " + loginLink.Enabled);
            loginLink.Click();
          
        }

        [When(@"user log in with valid credentials")]
        public void WhenUserLogInWithValidCredentials()
        {   
            //Validating email field 
            IWebElement emailField = driver.FindElement(By.Name("Email"));
            Assert.IsTrue(emailField.Enabled);
            emailField.SendKeys("KT211@gmail.com");
            Thread.Sleep(1000);

            //Validating password field 
            IWebElement passwordField = driver.FindElement(By.Name("Password"));
            Assert.IsTrue(passwordField.Enabled);
            Console.WriteLine("Password field Enabled = " + passwordField.Enabled);
            passwordField.SendKeys("1234567");
            Thread.Sleep(1000);

            //Validating login button
            IWebElement logInButton = driver.FindElement(By.XPath("(//button[@type='submit'])[2]"));
            Assert.IsTrue(logInButton.Enabled);
            Console.WriteLine("Login button enabled = " + logInButton.Enabled);
            logInButton.Click();
            Thread.Sleep(1000);

        }

        [Then(@"user is logged in successfully")]
        public void ThenUserIsLoggedInSuccessfully()
        {
            //Validating page title
            string expectedTitle = "nopCommerce demo store";
            string actualTitle = driver.Title;
            Console.WriteLine("Page title is " +actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(1000);
        }

        [When(@"user search for ""([^""]*)"" book")]
        public void WhenUserSearchForBook(string p0)
        {
            //Validating search field 
            IWebElement searchField = driver.FindElement(By.Id("small-searchterms"));
            Assert.IsTrue(searchField.Enabled);
            Console.WriteLine("Search field enabled = " + searchField.Enabled);
            searchField.SendKeys("Pride and Prejudice");
            Thread.Sleep(1000);
        }

        [When(@"user clicks on search button")]
        public void WhenUserClicksOnSearchButton()
        {
            //Validatig search button
            IWebElement searchButton = driver.FindElement(By.XPath("//button[@class='button-1 search-box-button']"));
            Assert.IsTrue(searchButton.Enabled);
            Console.WriteLine("Search button Enabled = " +searchButton.Enabled);
            searchButton.Click();
            Thread.Sleep(1000);

            IWebElement prideAndPrejudiceLink = driver.FindElement(By.XPath("//img[@src='https://demo.nopcommerce.com/images/thumbs/0000070_pride-and-prejudice_415.jpeg']"));
            Assert.IsTrue(prideAndPrejudiceLink.Enabled);
            prideAndPrejudiceLink.Click();
        }

        [Then(@"user is navigated to Pride and prejudice product details page")]
        public void ThenUserIsNavigatedToPrideAndPrejudiceProductDetailsPage()
        {
  
            //Validate page tile
            string expectedTitle = "nopCommerce demo store. Pride and Prejudice";
            string actualTitle = driver.Title;
            Console.WriteLine("Page title is " + actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(1000);

        }

        [When(@"user clicks on add to cart button of pride and prejudice product")]
        public void WhenUserClicksOnAddToCartButtonOfPrideAndPrejudiceProduct()
        {
            //Validating add to cart button
            IWebElement addToCartButton = driver.FindElement(By.XPath("//button[@id='add-to-cart-button-39']"));
            Assert.IsTrue(addToCartButton.Enabled);
            addToCartButton.Click();
            Thread.Sleep(3000);
        }

        [Then(@"product is added into the cart")]
        public void ThenProductIsAddedIntoTheCart()
        {
            //Validating cart count 
            IWebElement cartCount = driver.FindElement(By.XPath("//span[@class='cart-qty']"));
            string expectedCount = "(1)";
            string actualCount = cartCount.Text;
            Assert.AreEqual(expectedCount, actualCount);
            Console.WriteLine(actualCount);
        }

        [When(@"user clicks on shopping cart link")]
        public void WhenUserClicksOnShoppingCartLink()
        {
            //Validating shopping cart link
            IWebElement cartLink = driver.FindElement(By.LinkText("Shopping cart"));
            Assert.IsTrue(cartLink.Enabled);
            cartLink.Click();
            Thread.Sleep(2000);
        }

        [Then(@"user is navigated to shopping cart page")]
        public void ThenUserIsNavigatedToShoppingCartPage()
        {
            //Validating page title
            string expectedTitle = "nopCommerce demo store. Shopping Cart";
            string actualTitle = driver.Title;
            Console.WriteLine("Page title is " + actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(1000);
        }

        [When(@"user selects terms and condition checkbox")]
        public void WhenUserSelectsTermsAndConditionCheckbox()
        {
            //Validating terms and condition checkbox
            IWebElement termsAndConditionCheckbox = driver.FindElement(By.XPath("//input[@id='termsofservice']"));
            termsAndConditionCheckbox.Click();
            Thread.Sleep(1000);
        }

        [When(@"user clicks on checkout button")]
        public void WhenUserClicksOnCheckoutButton()
        {
            //Validating checkout button
            IWebElement checkoutButton = driver.FindElement(By.XPath("//button[@id='checkout']"));
            Assert.IsTrue(checkoutButton.Enabled);
            checkoutButton.Click();
            Thread.Sleep(2000);
        }

        [Then(@"user is navigated to checkout page")]
        public void ThenUserIsNavigatedToCheckoutPage()
        {
            //Validating page title
            string expectedTitle = "nopCommerce demo store. Checkout";
            string actualTitle = driver.Title;
            Console.WriteLine("Page title is " + actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(1000);
        }

        [When(@"user enters valid credentials on billing address form")]
        public void WhenUserEntersValidCredentialsOnBillingAddressForm()
        {
            //Validating billing address section fields

            IWebElement countryDropdown = driver.FindElement(By.Id("BillingNewAddress_CountryId"));
            SelectElement dropdown1 = new SelectElement(countryDropdown);
            dropdown1.SelectByIndex(100);
            Thread.Sleep(1000);

            IWebElement stateDropdown = driver.FindElement(By.Id("BillingNewAddress_StateProvinceId"));
            SelectElement dropdown2 = new SelectElement(stateDropdown);
            dropdown2.SelectByIndex(0);
            Thread.Sleep(1000);

            IWebElement cityField = driver.FindElement(By.Id("BillingNewAddress_City"));
            cityField.SendKeys("Vadodara");
            Thread.Sleep(1000);

            IWebElement address1Field = driver.FindElement(By.Id("BillingNewAddress_Address1"));
            address1Field.SendKeys("shubhanpura");
            Thread.Sleep(1000);

            IWebElement postalCodeField = driver.FindElement(By.Id("BillingNewAddress_ZipPostalCode"));
            postalCodeField.SendKeys("380054");
            Thread.Sleep(1000);

            IWebElement phoneNumberField = driver.FindElement(By.Id("BillingNewAddress_PhoneNumber"));
            phoneNumberField.SendKeys("1234567890");
            Thread.Sleep(1000);



        }

        [When(@"user clicks on continue button")]
        public void WhenUserClicksOnContinueButton()
        {
            //Validating continue button
            IWebElement continueButtton = driver.FindElement(By.XPath("(//button[@class='button-1 new-address-next-step-button'])[1]"));
            Assert.IsTrue(continueButtton.Enabled);
            Console.WriteLine("Continue button Enabled = " + continueButtton.Enabled);
            continueButtton.Click();
            Thread.Sleep(3000);
        }

        [When(@"user selects ground shipping method")]
        public void WhenUserSelectsGroundShippingMethod()
        {
            //Validatin Next day Radio button 
            IWebElement nextDayRadioButton = driver.FindElement(By.XPath("(//input[@name='shippingoption'])[2]"));
            Assert.IsTrue(nextDayRadioButton.Enabled);
           nextDayRadioButton.Click();

        }

        [When(@"user clicks on continue button of shipping method section")]
        public void WhenUserClicksOnContinueButtonOfShippingMethodSection()
        {
            //Validating continue buton
            IWebElement continueButton = driver.FindElement(By.XPath("(//button[text()='Continue'])[3]"));
            continueButton.Click();
            Thread.Sleep(1000);
        }

        [Then(@"user is navigated to payment page")]
        public void ThenUserIsNavigatedToPaymentPage()
        {
            //Validating page title
            string expectedTitle = "nopCommerce demo store. Checkout";
            string actualTitle = driver.Title;
            Console.WriteLine("Page title is " + actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(1000);

        }
        [When(@"user selects the credit card payment method")]
        public void WhenUserSelectsTheCreditCardPaymentMethod()
        {
            //Selecting credit card option
            IWebElement creditCardRadioButton = driver.FindElement(By.XPath("//input[@id='paymentmethod_1']"));
            creditCardRadioButton.Click();
            Thread.Sleep(1000);

            //Validating continue button
            IWebElement conitnueButton = driver.FindElement(By.XPath("//button[@class='button-1 payment-method-next-step-button']"));
            conitnueButton.Click();
            Thread.Sleep(1000);
        }
        [When(@"user enters valid credit card details")]
        public void WhenUserEntersValidCreditCardDetails()
        {
            //Select credit card
            IWebElement selectCreditCard = driver.FindElement(By.XPath("//select[@id='CreditCardType']"));
            SelectElement dropdown1 = new SelectElement(selectCreditCard); 
            dropdown1.SelectByIndex(0);
            Thread.Sleep(1000);

            //Enter cradholder name
            IWebElement cardHolderName = driver.FindElement(By.XPath("//input[@id='CardholderName']"));
            cardHolderName.SendKeys("Thakkar Kailash");
            Thread.Sleep(1000);

            //Enter card number
            IWebElement CardNumber = driver.FindElement(By.XPath("//input[@id='CardNumber']"));
            CardNumber.SendKeys("3566000020000410");
            Thread.Sleep(1000);

            //Select expiry month
            IWebElement expiryMonth = driver.FindElement(By.XPath("//select[@name='ExpireMonth']"));
            SelectElement dropdown2 = new SelectElement (expiryMonth);
            dropdown2.SelectByValue("2");
            Thread.Sleep(1000);

            //Select Expiry year
            IWebElement expireYear = driver.FindElement(By.XPath("//select[@name='ExpireYear']"));
            SelectElement dropdown3 = new SelectElement (expireYear); 
            dropdown3.SelectByValue("2026");
            Thread.Sleep(1000);

            //Enter card code
            IWebElement cardCode = driver.FindElement(By.XPath("//input[@id='CardCode']"));
            cardCode.SendKeys("123");

            IWebElement continue4 = driver.FindElement(By.XPath("//button[@class='button-1 payment-info-next-step-button']"));
            Assert.IsTrue(continue4.Enabled);
            continue4.Click();
            Thread.Sleep(1000);

        }
        [When(@"user clicks on continue button of payment info section")]
        public void WhenUserClicksOnContinueButtonOfPaymentInfoSection()
        {
            
            /*IWebElement continue5= driver.FindElement(By.XPath("(//button[text()='Continue'])[5]"));
            Assert.IsTrue(continue5.Enabled);
            continue5.Click();*/
           
        }

        [When(@"user clicks on confirm button")]
        public void WhenUserClicksOnConfirmButton()
        {
            //Clicking on confirm button
            IWebElement confirmButton = driver.FindElement(By.XPath("(//button[@type='button'])[13]"));
            Assert.IsTrue(confirmButton.Enabled);  
            Console.WriteLine(confirmButton.Enabled);
           confirmButton.Click();   
            Thread.Sleep(1000);
        }

        [Then(@"user has successfully purchased Pride and Prejudice book")]
        public void ThenUserHasSuccessfullyPurchasedPrideAndPrejudiceBook()
        {
            //Validating title of page
            IWebElement orderedSuccessfully = driver.FindElement(By.XPath("(//div[@class='title'])[1]"));
            Console.WriteLine(orderedSuccessfully.Text);  
            

            //Navigating to Order Details page
            IWebElement orderDetailsLink = driver.FindElement(By.LinkText("Click here for order details."));
            orderDetailsLink.Click();
            Thread.Sleep(2000);
            driver.Quit();


        
           }
        [When(@"user clicks on the log out link")]
        public void WhenUserClicksOnTheLogOutLink()
        {
            //User logging out
            IWebElement logOutLink = driver.FindElement(By.LinkText("Log out"));
            logOutLink.Click();
        }
      
        [Then(@"user is logged out successfully")]
        public void ThenUserIsLoggedOutSuccessfully()
        {
            //Validating landing page title
            string expectedTitle = "nopCommerce demo store";
            string actualTitle = driver.Title;
            Console.WriteLine("Page title is " + actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(1000);
            driver.Quit();
        }


    }
}
