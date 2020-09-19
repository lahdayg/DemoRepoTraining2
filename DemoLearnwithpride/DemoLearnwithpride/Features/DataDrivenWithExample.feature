Feature: DataDrivenWithExample
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario Outline: Data Driven With Example
	Given the User navigate to "https://www.qa.giftrete.com/"
	And the User click on create account
	And the User enter first name "<Firstname>"
	And the User enter last name "<Lastname>"
	And the User enter email address "<Email>"
	And the User click on the drop down arrow
	And the User select the country
	And the User enter mobile number "<Mobile>"
	And the User enter password "<Password1>"
	And the User confirm password "<Password2>"
	#When the User click on Register button
	#Then I should be registered

	Examples: 

	| Firstname | Lastname  | Email            | Mobile      | Password1 | Password2 |
	| Richard   | Hollywood | demo345@demo.com | 1234567890  | 123456    | 123456    |
	| David     | Femi      | demo333@demo.com | 22233345678 | 234567    | 234567    |
	