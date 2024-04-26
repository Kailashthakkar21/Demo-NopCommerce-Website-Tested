Feature: Ex05_SearchProductPage



@tag1
Scenario:01_Validate user can search for product successfully
Given chrome browser is open.
And app is opened 
When user enters a "Pride and Prejudce" in search field.
And clicks on Search button
Then user is able to search for product successfully.

Scenario:02_Validate user can search with invalid data 
Given chrome browser is open.
And app is opened 
When user enters a invalid "HP" in search field 
And clicks on Search button
Then user is not able to search for HP product.


