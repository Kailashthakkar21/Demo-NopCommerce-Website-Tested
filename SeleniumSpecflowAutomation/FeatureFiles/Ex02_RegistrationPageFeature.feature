Feature: Ex02_RegistrationPageFeature

Scenario:01_Validate user can register with valid data
Given the chrome browser is opened.
And the app is open.
When user clicks on register link
Then app shows registration page
When user enters "Kailash" in first name field
And user enters "Thakkar" in Last name field
And user enters "KT21@gmail.com"  in email field 
And user enters a "123456" in a password field 
And user enters a "123456" in a confirm password field 
And user clicks on register button
Then user is registered successfully

Scenario:02_Validate user can register with invalid data
Given the chrome browser is opened.
And the app is open.
When user clicks on register link
Then app shows registration page
When user enters "Kailash" in first name field
And user enters "Thakkar" in Last name field
And user enters invalid "kt21com" in email field 
And user enters a "123456" in a password field 
And user enters a "123456" in a confirm password field 
And user clicks on register button
Then user is not registered successfully

