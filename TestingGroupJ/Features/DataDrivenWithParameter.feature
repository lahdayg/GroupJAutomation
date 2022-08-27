Feature: DataDrivenWithParameter
	Simple calculator for adding two numbers

@mytag
Scenario: Data Driven With Parameter
	Given I navigate to "https://angularjs.realworld.io/#/"
	And I click on Sign up 
	And I enter my Username "voteobasanjoforpresident"
	And I enter my email "demo333"
	And I enter my password "PasswordSecure"
	When I click on sign up button
	Then I can register successfully

	