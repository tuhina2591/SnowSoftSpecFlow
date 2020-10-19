Feature: ArticleNumberTest
	When user accesses the Snow Software Page
	to navigate to Snow Globe community Page under Success Tab
	Here he can Search the Text and should be able to go to License Manager Page and Validate it

Background: 
Given URL "http://www.snowsoftware.com" is opened in "Chrome" browser

@mytag
Scenario: Validate Snow Software Title
	When Browser opens with Snow Home Page
	Then Title should be "Snow Software – The Technology Intelligence Platform"
	

Scenario: Verify Redirection to Snow Globe Page
	Given Snow Home page is open
	When I Hover on Success Tab
	And Click on Snow Globe Community Link
	Then the "Welcome to Snow Globe" Page should be opened	

#Scenario: User Navigation to Release Page
#	Given Browser is Open and user has navigated to Snow Globe Page
#	When I Enter 'Snow License Manager' 
#	And Click on Release Notes Link
#	Then I should be navigated to Release Manager Page
#