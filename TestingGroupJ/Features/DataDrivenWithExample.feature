Feature: DataDrivenWithExample
	Simple calculator for adding two numbers

@mytag
Scenario Outline: Data Driven With Example
	Given I navigate to "https://angularjs.realworld.io/#/"
	And I click on Sign up 
	And I enter my Username text "<Username>"
	And I enter my email text "<Email>"
	And I enter my password text "<Password>"
	When I click on sign up button
	Then I can register successfully

	Examples: 
	| Username | Email     | Password           |
	| Test1234 | demo2233  | PasswordSecure     |
	| Olamide  | olamide   | PasswordSecure2233 |
	| Nana     | alltheway | PasswordNana       |
	
	