Feature: Registration


As a user to benefit from this platform,
i have to register on the plafrom.
@tag1
Scenario:  Validate Registration 
	Given I navigate "https://angularjs.realworld.io/#/"
	And I click on the SignUp
	And I enter my Username "KQ123W123"
	And I enter my Email "example06@yahoo.com"
	And I enter my Password "Password"
	When I click on SignUp button 
	Then I should be able to register successfully 
