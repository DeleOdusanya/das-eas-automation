Feature: ForgottenPassword
	As an Employer
    I would like the ability to reset my forgotten password
@mytag
Scenario: Reset my password
	Given I on the sign in page
	When I click forgotten password
	And I submit valid email address
	And I enter valid code
	And I submit matching new password
	Then I should receive a confirmation that my password has been changed

Scenario: Reset my password - Invalid email address submitted
	Given I on the sign in page
	When I click forgotten password
	And I submit invalid email address
	Then I should prompted to enter a valid email address

Scenario: Reset my password - No email address submitted
	Given I on the sign in page
	When I click forgotten password
	And I submit No email address
	Then I should prompted to enter a valid email address

Scenario: Reset my password - Invalid code submitted
	Given I on the sign in page
	When I click forgotten password
	And I submit valid email address
	And I submit invalid code
	Then I should prompted to enter valid code

Scenario: Reset my password - No code submitted
	Given I on the sign in page
	When I click forgotten password
	And I submit valid email address
	And I submit No code
	Then I should prompted to enter valid code

Scenario: Reset my password - Unmatching new password submitted
	Given I on the sign in page
	When I click forgotten password
	And I submit valid email address
	And I enter valid code
	And I submit new password that do not match
	Then I should prompted to enter matching passwords
