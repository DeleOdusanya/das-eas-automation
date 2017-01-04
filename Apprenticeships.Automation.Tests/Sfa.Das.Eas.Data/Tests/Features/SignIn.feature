Feature: SignIn
	As an Employer
    I would like the ability to login to my DAS Account
    So that I can start using the Digital Apprenticeship Service

Scenario: Sign in with valid details
	Given I navigate to the Sign In page 
	When I submit valid details 
	Then I should be signed in to my account
	
Scenario: Sign in with invalid details
	Given I navigate to the Sign In page 
	When I submit invalid details 
	Then I should be prompted to enter valid details

Scenario: Sign in with no details
	Given I navigate to the Sign In page 
	When I submit no details 
	Then error messages to all fields will be displayed

