Feature: ArticleNumberTest
	When user accesses the Snow Software Page
	to navigate to Snow Globe community Page under Success Tab
	Here he can Search the Text and should be able to go to License Manager Page and Validate it


@mytag
Scenario: Validate Snow Software Title
	When URL "http://www.snowsoftware.com" is opened in "Chrome" browser
	Then Title should be "Snow Software – The Technology Intelligence Platform"
	

Scenario: Verify Redirection to Snow Globe Page
	Given "http://www.snowsoftware.com" is open in "Chrome"
	When I Hover on Success Tab
	And Click on Snow Globe Community Link
	Then the "Welcome to Snow Globe" Page should be opened	

Scenario: User Navigation to Release Page
	Given Welcome to Snow Globe is open in the "Chrome"
	When I enter "Snow License Manager" 
	And click on "Release Notes" link
	Then I should be navigated to "Release Notes: Snow License Manager 9.7.1" Page

Scenario: Validate Article Number
	Given User is on "Snow License Manager" Page in "Chrome"
	Then Article Number should be "000013119"

