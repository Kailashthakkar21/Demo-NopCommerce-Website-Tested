Feature: Ex12_UserInfoPageFeature


@tag1
Scenario:Validate user can save his personal details by cliking on save button
Given chrome browser is open..
And the app is opened..
When user click on login link 
Then app show login page
When user enter "KT21@gmail.com" in email field 
And user enter "123456" in a password field 
And user click on login in button
Then the user is loggen in successfully
When user clicks on the my account link
Then user is navigated to my account page
When user clicks on save button
Then user's personal info is saved is successfully