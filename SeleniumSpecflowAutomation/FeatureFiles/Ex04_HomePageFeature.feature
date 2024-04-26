Feature: Ex04_HomePageFeature

A short summary of the feature

@tag1
Scenario:01_Validate user can navigate to my account page
Given chrome browser is launched.
And the app is launched.
When user clicks on the login link 
Then user is navigated to login page
When user enters the "KT21@gmail.com" in email field 
And user enters the "123456" in password field
And user clicks on login button. 
Then user is navigated to Home page
When user clicks on My account link
Then user is navigated to my account page.

@tag1
Scenario:02_Validate user can log out successfully
Given chrome browser is launched.
And the app is launched.
When user clicks on the login link 
Then user is navigated to login page
When user enters the "KT21@gmail.com" in email field 
And user enters the "123456" in password field
And user clicks on login button. 
Then user is navigated to Home page
When user clicks on log out link
Then user is logged out successfully.

