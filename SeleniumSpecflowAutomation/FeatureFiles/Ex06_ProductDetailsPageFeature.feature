Feature: Ex06_ProductDetailsPage

A short summary of the feature

@tag1
Scenario:01_Validate user can add product into the cart 
Given chrome browser is opened
And the app is opened
When user enters "Pride And Prjudice" in search field 
And user clicks on search button.
And user clicks on Pride And Prjudice product image link
Then user is navigated to pride and prejudice product details
When user clicks on Add to cart button on pride and prejudice product details page
Then pride and prejudice product is added into the cart.

Scenario:02_Validate user can add product into the cart making the quantity of product negative
Given chrome browser is opened
And the app is opened
When user enters "Pride And Prjudice" in search field 
And user clicks on search button.
And user clicks on Pride And Prjudice product image link
Then user is navigated to pride and prejudice product details
When user enter "-1" the quantity fied of Pride And Prjudice product 
And user clicks on Add to cart button on pride and prejudice product details page
Then pride and prejudice product is not added into the cart.
