Feature: SignOut
	As an Employer
    I would like the ability to Sign out of my DAS Account
    And my session terminated

Scenario: Sign out of DAS account
	Given I am logged in
	When I click the Log Out link 
	Then I should be logged out of my account
	And returned to the homepage
