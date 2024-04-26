Feature: Ex01_LandingPageFeatur

@tag1
Scenario:01_Validate user can navigate to Register page after clicking on Register link
Given Chrome browser is open.
And app is opened.
Then app shows landing page
When user clicks on Register link
Then user navigates to Register page

@tag2
 Scenario:02_Validate user can navigate to Log in page after clicking on log in link
Given Chrome browser is open.
And app is opened.
Then app shows landing page
When user clicks on Log in link
Then user navigates to Log in page.
