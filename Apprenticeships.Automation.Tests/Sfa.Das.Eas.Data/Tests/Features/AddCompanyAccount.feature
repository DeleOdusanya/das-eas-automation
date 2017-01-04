Feature: AddCompanyAccount
	As an Employer
    I would like the ability to add company account to my DAS Account
    So that I can start using the Digital Apprenticeship Service

@mytag
    Scenario: Add company account to my DAS Account
	Given I am logged into my DAS Account
	When I enter my company number 
	And I click continue to connect to Hmrc
	And I enter Government gateway ID with password
	Then the company should be added to the DAS Account
#
#    Scenario: Attempt to Add Invalid Company number
#	Given I am logged into my DAS Account
#	When I enter an Invalid company number 
#	And I click continue to connect to Hmrc
#	And I enter Government gateway ID with password
#	Then I should be prompted to Enter a valid Companies House number
#
#	Scenario: Attempt to Add Valid Company number with Invalid Government Gateway ID
#	Given I am logged into my DAS Account
#	When I enter my company number 
#	And I click continue to connect to Hmrc
#	And I enter an invalid Government gateway ID with password
#	Then I should be prompted to Enter valid credentials
#
