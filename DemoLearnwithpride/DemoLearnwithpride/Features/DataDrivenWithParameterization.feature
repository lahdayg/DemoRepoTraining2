Feature: DataDrivenWithParameterization
	In order to know more about Selenium
	I want to learn using Data Driven

@mytag
Scenario: Data Driven With Parameters
	Given I navigae to "https://www.qa.giftrete.com/"
	And I click on create account
	And I enter my first name "orimogunje"
	And I enter my last name "Richardson"
	And I enter my email address "demo+22@example.com"
	And I click on the drop down arrow
	And I select the country
	And I enter my mobile number "1234567890"
	And I enter my password "123456"
	And I confirm password "123456"
	#When I click on Register button
	#Then I should be registered



	