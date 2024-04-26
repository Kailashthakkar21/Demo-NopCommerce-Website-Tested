Feature: Ex10_PaymentPageFeature



@tag1
Scenario:01_Validate user can navigate to confirm order page after entering valid card details
Given the chrome browser is open..
And app is open..
When user clicks on the log in link.
Then user is navigated to log in page.
When user logs in with valid data.
Then user is logged in  successfully.
When user enters the "Pride And Prejudice" in the search field.
And user clicks the search button
And user clicks the Pride And Prjudice product image link.
Then user is navigated to pride and prejudice product details page
When user clicks on the Add to cart button on the pride and prejudice product details page.
Then pride and prejudice product is added to cart
When user clicks on the shopping cart link
Then user is navigated to shopping cart page.
When user click on terms and condition checkbox
And user click on checkout button
Then user is navigated to the checkout page.
When user selects "India" country form country dropdown.
And user enters "Vadodara" in city field.
And user enters "Shubhanpura" in address1 field
And user enters "380054" in postal conde field.
And user enters "1234567890" in phone number field.
And user clicks on the continue button
And user selects shipping method.
And user clicks on continue button on shipping method section.
Then user is navigated to payment page.
When user selects credit card payment method 
And user clicks on continue button..
And user enters valid credit card details.
And user clicks on continue button of payment info section.
Then user is navigated to confirm order page successfully


Scenario:02_Validate user can navigate to confirm order page after entering invalid card details
Given the chrome browser is open..
And app is open..
When user clicks on the log in link.
Then user is navigated to log in page.
When user logs in with valid data.
Then user is logged in  successfully.
When user enters the "Pride And Prejudice" in the search field.
And user clicks the search button
And user clicks the Pride And Prjudice product image link.
Then user is navigated to pride and prejudice product details page
When user clicks on the Add to cart button on the pride and prejudice product details page.
Then pride and prejudice product is added to cart
When user clicks on the shopping cart link
Then user is navigated to shopping cart page.
When user click on terms and condition checkbox
And user click on checkout button
Then user is navigated to the checkout page.
When user selects "India" country form country dropdown.
And user enters "Vadodara" in city field.
And user enters "Shubhanpura" in address1 field
And user enters "380054" in postal conde field.
And user enters "1234567890" in phone number field.
And user clicks on the continue button
And user selects shipping method.
And user clicks on continue button on shipping method section.
Then user is navigated to payment page.
When user selects credit card payment method 
And user clicks on continue button..
And user enters invalid credit card details.
And user clicks on continue button of payment info section.
Then user is navigated to confirm order page successfully
