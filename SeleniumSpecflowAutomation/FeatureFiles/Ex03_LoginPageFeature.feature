Feature: Ex03_LoginPageFeature




@tag1
Scenario:01_Validate user can login with valid data
Given the chrome browser is open.
And app is open.
When user clicks on login link 
Then apps show login page
When user enters "KT21@gmail.com" in email field 
And user enters "123456" in a password field 
And user clicks on login in button
Then user is loggen in successfully

@tag2
Scenario:02_Validate user can login with invalid data
Given the chrome browser is open.
And app is open.
When user clicks on login link 
Then apps show login page
When user enters "KT21@gmail.com" in email field 
And user enters invalid "123" in a password field 
And user clicks on login in button
Then user is not able to log in successfully
