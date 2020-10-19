Feature: ArticleNumberTest
	When user accesses the Snow Software Page
	to navigate to Snow Globe community Page under Success Tab
	Here he can Search the Text and should be able to go to License Manager Page and Validate it

@mytag
Scenario: Launch the Chrome Browser and Validate URL
	Given I launch Snow Software URL with any browser
	When the page is opened
	Then the Snow Home Page should be opened
	And the browser should be closed afterwards

Scenario: Navigate to Snow Globe Page and Verify Redirection
	Given My Browser is Open with Snow Software URL
	When I Hover on Success Tab
	And Click on Snow Globe Community Link
	Then the Welcome to Snow Globe Page should be opened
	And the browser should be closed afterwards