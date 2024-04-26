Feature: Ex08_AddToCartPageFeature

A short summary of the feature

@tag1
Scenario:01_Validate user can navigate to checkout page after clicking on checkout button
Given the chrome browser is opened
And app is open
When user enters "Pride And Prejudice" in the search field 
And user clicks search button.
And user clicks Pride And Prjudice product image link
Then user is navigated to the pride and prejudice product details
When user clicks on the Add to cart button on pride and prejudice product details page
Then pride and prejudice product is added into cart.
When user clicks on theshopping cart link 
Then user is navigated to the shopping cart page
When user clicks on terms and condition checkbox
And user clicks on the checkout button
Then user is navigated to checkout page.

@tag2
Scenario:02_Validate user can update cart making the quantity of product negative
Given the chrome browser is opened
And app is open
When user enters "Pride And Prejudice" in the search field 
And user clicks search button.
And user clicks Pride And Prjudice product image link
Then user is navigated to the pride and prejudice product details
When user clicks on the Add to cart button on pride and prejudice product details page
Then pride and prejudice product is added into cart.
When user clicks on theshopping cart link 
Then user is navigated to the shopping cart page
When user enters "-1" in the qty field
And user clicks update cart button
Then shopping cart is not updated


