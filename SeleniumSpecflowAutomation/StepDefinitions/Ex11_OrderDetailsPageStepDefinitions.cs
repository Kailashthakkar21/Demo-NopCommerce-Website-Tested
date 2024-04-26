using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.DevTools.V85.HeapProfiler;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Threading;
using TechTalk.SpecFlow;

namespace AT_FinalAssignment_Project_KailashThakkar.StepDefinitions
{
    [Binding]
    public class Ex11_OrderDetailsPageStepDefinitions
    {
        IWebDriver driver;
        string url = "https://demo.nopcommerce.com/";

        [Given(@"chrome browser is opened\.\.")]
        public void GivenChromeBrowserIsOpened_()
        {
            //Launching the chrome browser
            driver = new ChromeDriver(".");
            driver.Manage().Window.Maximize();
        }

        [Given(@"The app is open\.\.")]
        public void GivenTheAppIsOpen_()
        {
            //Launching the app
            driver.Url = url;
        }

        [When(@"user click on the log in link\.")]
        public void WhenUserClickOnTheLogInLink_()
        {
            //Validating log in link with assertion
            IWebElement loginLink = driver.FindElement(By.LinkText("Log in"));
            Assert.IsTrue(loginLink.Enabled);
            Console.WriteLine("login link enabled = " + loginLink.Enabled);
            loginLink.Click();
        }

        [Then(@"user is navigated to log in page\.\.")]
        public void ThenUserIsNavigatedToLogInPage_()
        {
            //Validating page title with assertion
            string expectedTitle = "nopCommerce demo store. Login";
            string actualTitle = driver.Title;
            Assert.AreEqual(expectedTitle, actualTitle);
            Console.WriteLine(actualTitle);
            Thread.Sleep(2000); 
        }

        [When(@"user log in with valid data\.")]
        public void WhenUserLogInWithValidData_()
        {
            IWebElement emailField = driver.FindElement(By.Id("Email"));
            emailField.SendKeys("KT21@gmail.com");
            IWebElement passwordField = driver.FindElement(By.Id("Password"));
            passwordField.SendKeys("123456");
            //Validating login button
            IWebElement logInButton = driver.FindElement(By.XPath("(//button[@type='submit'])[2]"));
            Assert.IsTrue(logInButton.Enabled);
            Console.WriteLine("Login button enabled = " + logInButton.Enabled);
            logInButton.Click();
            Thread.Sleep(1000);
        }
        [Then(@"user is logged in successfully\.\.")]
        public void ThenUserIsLoggedInSuccessfully_()
        {
            //Validating landing page title 
            Console.WriteLine("Landing page is visible");
            string expectedTitle = "nopCommerce demo store";
            string actualTitle = driver.Title;
            Assert.AreEqual(expectedTitle, actualTitle);
            Console.WriteLine(actualTitle);
            Thread.Sleep(2000);
        }

        [When(@"user enter the ""([^""]*)"" in the search field\.")]
        public void WhenUserEnterTheInTheSearchField_(string p0)
        {
            //Validating search field 
            IWebElement searchField = driver.FindElement(By.Id("small-searchterms"));
            Assert.IsTrue(searchField.Enabled);
            Console.WriteLine("Search field enabled = " + searchField.Enabled);
            searchField.SendKeys(p0);
            Thread.Sleep(1000);
        }

        [When(@"user click the search button")]
        public void WhenUserClickTheSearchButton()
        {
            //Validatig search button
            IWebElement searchButton = driver.FindElement(By.XPath("//button[@class='button-1 search-box-button']"));
            Assert.IsTrue(searchButton.Enabled);
            Console.WriteLine("Search button Enabled = " + searchButton.Enabled);
            searchButton.Click();
            Thread.Sleep(1000);
        }

        [When(@"user click the Pride And Prjudice product image link\.")]
        public void WhenUserClickThePrideAndPrjudiceProductImageLink_()
        {
            IWebElement prideAndPrejudiceLink = driver.FindElement(By.XPath("//img[@src='https://demo.nopcommerce.com/images/thumbs/0000070_pride-and-prejudice_415.jpeg']"));
            Assert.IsTrue(prideAndPrejudiceLink.Enabled);
            prideAndPrejudiceLink.Click();
        }

        [Then(@"user is navigated to the  pride and prejudice product details page")]
        public void ThenUserIsNavigatedToThePrideAndPrejudiceProductDetailsPage()
        {
            //Validate page tile
            string expectedTitle = "nopCommerce demo store. Pride and Prejudice";
            string actualTitle = driver.Title;
            Console.WriteLine("Page title is " + actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(1000);
        }

        [When(@"user clicks on Add to cart button on the pride and prejudice product details page\.")]
        public void WhenUserClicksOnAddToCartButtonOnThePrideAndPrejudiceProductDetailsPage_()
        {
            //Validating add to cart button
            IWebElement addToCartButton = driver.FindElement(By.XPath("(//button[@data-productid='39'])[1]"));
            Assert.IsTrue(addToCartButton.Enabled);
            addToCartButton.Click();
            Thread.Sleep(2000);
        }

        [Then(@"pride and prejudice product is added to cart\.")]
        public void ThenPrideAndPrejudiceProductIsAddedToCart_()
        {
            throw new PendingStepException();
        }

        [When(@"user clicks on the shopping cart link\.")]
        public void WhenUserClicksOnTheShoppingCartLink_()
        {
            //Validating shopping cart link
            IWebElement cartLink = driver.FindElement(By.LinkText("Shopping cart"));
            Assert.IsTrue(cartLink.Enabled);
            cartLink.Click();
            Thread.Sleep(2000);
        }
     [Then(@"the user is navigated to shopping cart page")]
        public void ThenTheUserIsNavigatedToShoppingCartPage()
        {
            //Validating page title
            string expectedTitle = "nopCommerce demo store. Shopping Cart";
            string actualTitle = driver.Title;
            Console.WriteLine("Page title is " + actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(1000);
        }

        [When(@"user click on terms and condition checkbox\.")]
        public void WhenUserClickOnTermsAndConditionCheckbox_()
        {
            //Validating terms and condition checkbox
            IWebElement termsAndConditionCheckbox = driver.FindElement(By.XPath("//input[@id='termsofservice']"));
            termsAndConditionCheckbox.Click();
            Thread.Sleep(1000);
        }

        [When(@"user click on checkout button\.")]
        public void WhenUserClickOnCheckoutButton_()
        {
            //Validating checkout button
            IWebElement checkoutButton = driver.FindElement(By.XPath("//button[@id='checkout']"));
            Assert.IsTrue(checkoutButton.Enabled);
            checkoutButton.Click();
            Thread.Sleep(2000);
        }

        [Then(@"the buser is navigated to checkout page\.")]
        public void ThenTheBuserIsNavigatedToCheckoutPage_()
        {
            //Validating page title
            string expectedTitle = "nopCommerce demo store. Checkout";
            string actualTitle = driver.Title;
            Console.WriteLine("Page title is " + actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(1000);
        }

        [When(@"user select ""([^""]*)"" country form country dropdown\.")]
        public void WhenUserSelectCountryFormCountryDropdown_(string india)
        {
            IWebElement countryDropdown = driver.FindElement(By.Id("BillingNewAddress_CountryId"));
            SelectElement dropdown1 = new SelectElement(countryDropdown);
            dropdown1.SelectByIndex(100);
            Thread.Sleep(1000);
        }

        [When(@"user enter ""([^""]*)"" in city field\.")]
        public void WhenUserEnterInCityField_(string vadodara)
        {
            IWebElement cityField = driver.FindElement(By.Id("BillingNewAddress_City"));
            cityField.SendKeys(vadodara);
            Thread.Sleep(1000);
        }

        [When(@"user enter ""([^""]*)"" in address(.*) field")]
        public void WhenUserEnterInAddressField(string shubhanpura, int p1)
        {
            IWebElement address1Field = driver.FindElement(By.Id("BillingNewAddress_Address1"));
            address1Field.SendKeys(shubhanpura);
            Thread.Sleep(1000);
        }

        [When(@"user enter ""([^""]*)"" in postal conde field\.")]
        public void WhenUserEnterInPostalCondeField_(string p0)
        {
            IWebElement postalCodeField = driver.FindElement(By.Id("BillingNewAddress_ZipPostalCode"));
            postalCodeField.SendKeys(p0);
            Thread.Sleep(1000);
        }

        [When(@"user enter ""([^""]*)"" in phone number field\.")]
        public void WhenUserEnterInPhoneNumberField_(string p0)
        {
            IWebElement phoneNumberField = driver.FindElement(By.Id("BillingNewAddress_PhoneNumber"));
            phoneNumberField.SendKeys(p0);
            Thread.Sleep(1000);
        }

        [When(@"user click on the continue button")]
        public void WhenUserClickOnTheContinueButton()
        {
            //Validating continue button
            IWebElement continueButtton = driver.FindElement(By.XPath("(//button[@class='button-1 new-address-next-step-button'])[1]"));
            Assert.IsTrue(continueButtton.Enabled);
            Console.WriteLine("Continue button Enabled = " + continueButtton.Enabled);
            continueButtton.Click();
            Thread.Sleep(3000);
        }

        [When(@"user select shipping method\.")]
        public void WhenUserSelectShippingMethod_()
        {
            //Validatin Next day Radio button 
            IWebElement nextDayRadioButton = driver.FindElement(By.XPath("(//input[@name='shippingoption'])[2]"));
            Assert.IsTrue(nextDayRadioButton.Enabled);
            nextDayRadioButton.Click();
        }

        [When(@"user click on continue button on shipping method section\.")]
        public void WhenUserClickOnContinueButtonOnShippingMethodSection_()
        {
            //Validating continue buton
            IWebElement continueButton = driver.FindElement(By.XPath("(//button[text()='Continue'])[3]"));
            continueButton.Click();
            Thread.Sleep(1000);
        }

        [Then(@"user is navigated to the payment page\.")]
        public void ThenUserIsNavigatedToThePaymentPage_()
        {
            // Validating page title
            string expectedTitle = "nopCommerce demo store. Checkout";
            string actualTitle = driver.Title;
            Console.WriteLine("Page title is " + actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(1000);
        }

        [When(@"user select credit card payment method")]
        public void WhenUserSelectCreditCardPaymentMethod()
        {
            //Selecting credit card option
            IWebElement creditCardRadioButton = driver.FindElement(By.XPath("//input[@id='paymentmethod_1']"));
            creditCardRadioButton.Click();
            Thread.Sleep(1000);
        }

        [When(@"user click on continue button\.\.")]
        public void WhenUserClickOnContinueButton_()
        {
            //Validating continue button
            IWebElement conitnueButton = driver.FindElement(By.XPath("//button[@class='button-1 payment-method-next-step-button']"));
            conitnueButton.Click();
            Thread.Sleep(1000);
        }

        [When(@"user enter valid credit card details\.")]
        public void WhenUserEnterValidCreditCardDetails_()
        {
            //Select credit card
            IWebElement selectCreditCard = driver.FindElement(By.XPath("//select[@id='CreditCardType']"));
            SelectElement dropdown1 = new SelectElement(selectCreditCard);
            dropdown1.SelectByIndex(0);
            Thread.Sleep(1000);

            //Enter cradholder name
            IWebElement cardHolderName = driver.FindElement(By.XPath("//input[@id='CardholderName']"));
            cardHolderName.SendKeys("Thakkar Kailash");
            Thread.Sleep(2000);

            //Enter card number
            IWebElement CardNumber = driver.FindElement(By.XPath("//input[@id='CardNumber']"));
            CardNumber.SendKeys("3566000020000410");
            Thread.Sleep(2000);

            //Select expiry month
            IWebElement expiryMonth = driver.FindElement(By.XPath("//select[@name='ExpireMonth']"));
            SelectElement dropdown2 = new SelectElement(expiryMonth);
            dropdown2.SelectByValue("2");
            Thread.Sleep(2000);

            //Select Expiry year
            IWebElement expireYear = driver.FindElement(By.XPath("//select[@name='ExpireYear']"));
            SelectElement dropdown3 = new SelectElement(expireYear);
            dropdown3.SelectByValue("2026");
            Thread.Sleep(2000);

            //Enter card code
            IWebElement cardCode = driver.FindElement(By.XPath("//input[@id='CardCode']"));
            cardCode.SendKeys("123");
        }

            [When(@"user click on continue button of payment info section\.")]
        public void WhenUserClickOnContinueButtonOfPaymentInfoSection_()
        {
            IWebElement continue4 = driver.FindElement(By.XPath("//button[@class='button-1 payment-info-next-step-button']"));
            continue4.Click();
            Thread.Sleep(1000);
        }

        [Then(@"user is navigated to the confirm order page successfully")]
        public void ThenUserIsNavigatedToTheConfirmOrderPageSuccessfully()
        {
            //Valdating total of product on confirm order page
            IWebElement productTotal = driver.FindElement(By.XPath("//strong[text()='$24.00']"));
            Console.WriteLine(productTotal.Text);
        }

        [When(@"user clicks on confirm button\.")]
        public void WhenUserClicksOnConfirmButton_()
        {
            //Clicking on confirm button
            IWebElement confirmButton = driver.FindElement(By.XPath("(//button[@type='button'])[13]"));
            confirmButton.Click();
            Thread.Sleep(1000);
        }

        [Then(@"order is placed successfully")]
        public void ThenOrderIsPlacedSuccessfully()
        {
            //Validating title of page
            IWebElement orderedSuccessfully = driver.FindElement(By.XPath("(//div[@class='title'])[1]"));
            Console.WriteLine(orderedSuccessfully.Text);
        }

        [When(@"user clicks on click here for order details links")]
        public void WhenUserClicksOnClickHereForOrderDetailsLinks()
        {
            //Navigating to Order Details page
            IWebElement orderDetailsLink = driver.FindElement(By.LinkText("Click here for order details."));
            orderDetailsLink.Click();
            Thread.Sleep(2000);
        }

        [Then(@"user is navigated to order details page")]
        public void ThenUserIsNavigatedToOrderDetailsPage()
        {
            // Validating page title
            string expectedTitle = "nopCommerce demo store. Order Details";
            string actualTitle = driver.Title;
            Console.WriteLine("Page title is " + actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(1000);
        }

        [When(@"user clicks on PDF invoice button")]
        public void WhenUserClicksOnPDFInvoiceButton()
        {
            IWebElement pdfInvoiceButton = driver.FindElement(By.ClassName("button-2 pdf-invoice-button"));
            pdfInvoiceButton.Click();
        }

        [Then(@"invoice pdf is downloaded successfully")]
        public void ThenInvoicePdfIsDownloadedSuccessfully()
        {
            //Validating page title
            // Validating page title
            string expectedTitle = "nopCommerce demo store. Order Details";
            string actualTitle = driver.Title;
            Console.WriteLine("Page title is " + actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(1000);
        }

        [When(@"user clicks on reoder button")]
        public void WhenUserClicksOnReoderButton()
        {
            IWebElement reorderButton = driver.FindElement(By.ClassName("button-1 re-order-button"));
            reorderButton.Click();
            Thread.Sleep(1000);
        }

        [Then(@"user is able to rorder the product successfully\.")]
        public void ThenUserIsAbleToRorderTheProductSuccessfully_()
        {
            //User is navigated to shopping cart page after clicking on reorder button
            //Validating page title
            string expectedTitle = "nopCommerce demo store. Shopping Cart";
            string actualTitle = driver.Title;
            Console.WriteLine("Page title is " + actualTitle);
            Assert.AreEqual(expectedTitle, actualTitle);
            Thread.Sleep(1000);

      
        }
    }
}
