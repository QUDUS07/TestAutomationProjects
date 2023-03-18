Feature: Feature1

As a User In Order to
Benefit From the website
I will need to  first register
@tag1
Scenario: Validate Registration 
	Given  I navigate to the website
	And I click on Sign up
	And I enter Username
	And I enter Email
	And I enter password
	When I click on the sign up botton
	Then I should be able to register successfully
