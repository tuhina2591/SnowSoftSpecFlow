Feature: ArticleNumberTest
	When user accesses the Snow Software Page
	to navigate to Snow Globe community Page under Success Tab
	Here he can Search the Text and should be able to go to License Manager Page and Validate it


@mytag
Scenario: 1 Validate Snow Software Title
	Given Broswer is Launched
	When URL "http://www.snowsoftware.com" is accesed
	Then the Title should be "Snow Software – The Technology Intelligence Platform"

Scenario: 2 Verify Redirection to Snow Globe Page
	Given SnowSoft URL "http://www.snowsoftware.com" is accessed
	When User Hover on Success Tab
	And Clicks on Snow Globe Community Link
	Then "Welcome to Snow Globe" Page should be opened	

Scenario: 3 User Navigation to Release Page
	Given URL "http://www.snowsoftware.com" is accessed
	And the Snow Globe Page via Success Link is open
	When he enters "Snow License Manager" in SearchBox
	And clicks on "Release Notes" link
	Then he should be navigated to "Release Notes: Snow License Manager 9.7.1" Page

Scenario: 4 Validate Article Number
	Given User is on "http://www.snowsoftware.com"
	* Snow Globe Page using Success Link is open
	* "Snow License Manager" is entered in SearchBox
	* "Release Notes" Link is Clicked
	Then the Article Number should be "000013119"

