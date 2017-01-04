Feature: ChangeSettingsInformation
	As an Employer
    I would like the ability to Change my settings information


Scenario: Change password - form submitted with valid details
	Given I'm logged in to my DAS account
	When I submit new password
	And enter the auth code
	Then I should receive a confirmation that my password has been changed

Scenario: Change password - form submit with new password not entered
	Given I'm logged in to my DAS account
	When I submit new password
	And enter the auth code
	Then I should receive a confirmation that my password has been changed

Scenario: Change password - form submit with new passwords that do not match
	Given I'm logged in to my DAS account
	When I submit new password
	And enter the auth code
	Then I should receive a confirmation that my password has been changed

Scenario: Change Email
	Given I'm logged in to my DAS account
	When I submit new email
	And enter the auth code
	Then I should receive a confirmation that my email has been changed

Scenario: Change Email - form submit with new Email not entered
	Given I'm logged in to my DAS account
	When I submit new email
	And enter the auth code
	Then I should receive a confirmation that my email has been changed

Scenario: Change Email - form submit with new Emails that do not match
	Given I'm logged in to my DAS account
	When I submit new email
	And enter the auth code
	Then I should receive a confirmation that my email has been changed