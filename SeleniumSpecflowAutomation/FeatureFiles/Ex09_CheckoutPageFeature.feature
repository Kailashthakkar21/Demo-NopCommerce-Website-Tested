Feature: Ex09_CheckoutPageFeature

A short summary of the feature

@tag1
Scenario:01_Validate user can checkout successfully with valid data
Given the chrome browser is opened..
And app is opened..
When user clicks on the log in link
Then user is navigated to log in page
When user logs in with valid data 
Then user is logged in successfully.
When user enters the "Pride And Prejudice" in the search field 
And user clicks the search button.
And user clicks the Pride And Prjudice product image link
Then user is navigated to the pride and prejudice product details page.
When user clicks on the Add to cart button on pride and prejudice product details page.
Then pride and prejudice product is added into cart
When user clicks on theshopping cart link.
Then user is navigated to the shopping cart page.
When user clicks on terms and condition checkbox.
And user clicks on the checkout button.
Then user is navigated to the checkout page
When user selects "India" country form country dropdown
And user enters "Vadodara" in city field
And user enters "Shubhanpura" in address1 field.
And user enters "380054" in postal conde field
And user enters "1234567890" in phone number field 
And user clicks on continue button.
And user selects shipping method
And user clicks on continue button on shipping method section
Then user is checked out successfully.

Scenario:02_Validate user can checkout with invalid data
Given the chrome browser is opened..
And app is opened..
When user clicks on the log in link
Then user is navigated to log in page
When user logs in with valid data 
Then user is logged in successfully.
When user enters the "Pride And Prejudice" in the search field 
And user clicks the search button.
And user clicks the Pride And Prjudice product image link
Then user is navigated to the pride and prejudice product details page.
When user clicks on the Add to cart button on pride and prejudice product details page.
Then pride and prejudice product is added into cart
When user clicks on theshopping cart link.
Then user is navigated to the shopping cart page.
When user clicks on terms and condition checkbox.
And user clicks on the checkout button.
Then user is navigated to the checkout page
When user selects "India" country form country dropdown
And user enters "Vadodara" in city field
And user enters "Shubhanpura" in address1 field.
And user enters "380054" in postal conde field
And user keeps phone number field blank
And user clicks on continue button.
Then user is not able to check out.

