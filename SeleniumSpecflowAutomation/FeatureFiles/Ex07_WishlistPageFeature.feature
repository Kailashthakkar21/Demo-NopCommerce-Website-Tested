Feature: Ex07_WishlistPageFeature

A short summary of the feature

@tag1
Scenario:01_Validate user can add product into cart from Wishlist page.
Given chrome browser is open
And the app is open
When user enters the "Pride And Prejudice" in search field 
And user clicks on the search button.
And user clicks on the Pride And Prjudice product image link
Then user is navigated to the pride and prejudice product details page
When user clicks on Add to wishlist button on pride and prejudice product details page
Then product is added into the wishlist 
When user clicks on wishlist link
Then user is navigated to wishlist page
When user clicks on add to cart checkbox 
And user clicks on add to cart button 
Then product is added into cart from wishlist page

@tag2
Scenario:02_Validate user can update wishlist making the quantity of product negative
Given chrome browser is open
And the app is open
When user enters the "Pride And Prejudice" in search field 
And user clicks on the search button.
And user clicks on the Pride And Prjudice product image link
Then user is navigated to the pride and prejudice product details page
When user clicks on Add to wishlist button on pride and prejudice product details page
Then product is added into the wishlist 
When user clicks on wishlist link
Then user is navigated to wishlist page
When user enters the "-1" in qty field
And user clicks on update button 
Then wishlist is not updated
