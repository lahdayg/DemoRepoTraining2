Feature: Registration
	As a User
	In order to use Amazon website
	I will need to first register

@mytag

Scenario: Valid Registration
	Given I navigate to www.amazon.co.uk
	And I click on Hello Sign In
	And I click on create your amazon account
	And I enter my name
	And I enter my email
	And I enter my password
	And I re-enter my password
	When I click on create your amazon account in the registration page
	Then my account should be created



