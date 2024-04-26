Feature: Ex001_EndToEndFlowFeature


@tag1
Scenario:01_Validate user can purchase "Pride and Prejudice" book successfully
Given chrome browser is opened.
And the app is opened.
When user clicks on log in link
And user log in with valid credentials
Then user is logged in successfully
When user search for "Pride and Prejudice" book 
And user clicks on search button 
Then user is navigated to Pride and prejudice product details page
When user clicks on add to cart button of pride and prejudice product
Then product is added into the cart 
When user clicks on shopping cart link 
Then user is navigated to shopping cart page
When user selects terms and condition checkbox 
And user clicks on checkout button 
Then user is navigated to checkout page
When user enters valid credentials on billing address form
And user clicks on continue button 
And user selects ground shipping method
And user clicks on continue button of shipping method section
Then user is navigated to payment page 
When user selects the credit card payment method
And user enters valid credit card details
And user clicks on continue button of payment info section 
And user clicks on confirm button 
Then user has successfully purchased Pride and Prejudice book

@tag2
Scenario:02_Validate user can log out after successfully purchasing "Pride and Prejudice" book successfully
Given chrome browser is opened.
And the app is opened.
When user clicks on log in link
And user log in with valid credentials
Then user is logged in successfully
When user search for "Pride and Prejudice" book 
And user clicks on search button 
Then user is navigated to Pride and prejudice product details page
When user clicks on add to cart button of pride and prejudice product
Then product is added into the cart 
When user clicks on shopping cart link 
Then user is navigated to shopping cart page
When user selects terms and condition checkbox 
And user clicks on checkout button 
Then user is navigated to checkout page
When user enters valid credentials on billing address form
And user clicks on continue button 
And user selects ground shipping method
And user clicks on continue button of shipping method section
Then user is navigated to payment page 
When user selects the credit card payment method
And user enters valid credit card details
And user clicks on continue button of payment info section 
And user clicks on confirm button 
Then user has successfully purchased Pride and Prejudice book
When user clicks on the log out link 
Then user is logged out successfully