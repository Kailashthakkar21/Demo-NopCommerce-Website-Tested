Feature: Ex11_OrderDetailsPage



@tag1
Scenario:01_Validate user can download order information invoice pdf by clicking on PDF Invoice button
Given chrome browser is opened..
And The app is open..
When user click on the log in link.
Then user is navigated to log in page..
When user log in with valid data.
Then user is logged in successfully..
When user enter the "Pride And Prejudice" in the search field.
And user click the search button
And user click the Pride And Prjudice product image link.
Then user is navigated to the  pride and prejudice product details page
When user clicks on Add to cart button on the pride and prejudice product details page.
Then pride and prejudice product is added to cart.
When user clicks on the shopping cart link.
Then the user is navigated to shopping cart page
When user click on terms and condition checkbox.
And user click on checkout button.
Then the buser is navigated to checkout page.
When user select "India" country form country dropdown.
And user enter "Vadodara" in city field.
And user enter "Shubhanpura" in address1 field
And user enter "380054" in postal conde field.
And user enter "1234567890" in phone number field.
And user click on the continue button
And user select shipping method.
And user click on continue button on shipping method section.
Then user is navigated to the payment page.
When user select credit card payment method 
And user click on continue button..
And user enter valid credit card details.
And user click on continue button of payment info section.
Then user is navigated to the confirm order page successfully
When user clicks on confirm button.
Then order is placed successfully
When user clicks on click here for order details links 
Then user is navigated to order details page
When user clicks on PDF invoice button
Then invoice pdf is downloaded successfully

@tag2
Scenario:02_Validate user can reorder the product 
Given chrome browser is opened..
And he app is open..
When user click on the log in link.
Then user is navigated to log in page..
When user log in with valid data.
Then user is logged in successfully..
When user enter the "Pride And Prejudice" in the search field.
And user click the search button
And user click the Pride And Prjudice product image link.
Then user is navigated to the  pride and prejudice product details page
When user clicks on Add to cart button on the pride and prejudice product details page.
Then pride and prejudice product is added to cart.
When user clicks on the shopping cart link.
Then the user is navigated to shopping cart page
When user click on terms and condition checkbox.
And user click on checkout button.
Then the buser is navigated to checkout page.
When user select "India" country form country dropdown.
And user enter "Vadodara" in city field.
And user enter "Shubhanpura" in address1 field
And user enter "380054" in postal conde field.
And user enter "1234567890" in phone number field.
And user click on the continue button
And user select shipping method.
And user click on continue button on shipping method section.
Then user is navigated to the payment page.
When user select credit card payment method 
And user click on continue button..
And user enter valid credit card details.
And user click on continue button of payment info section.
Then user is navigated to the confirm order page successfully
When user clicks on confirm button.
Then order is placed successfully
When user clicks on click here for order details links 
Then user is navigated to order details page
When user clicks on reoder button
Then user is able to rorder the product successfully.
