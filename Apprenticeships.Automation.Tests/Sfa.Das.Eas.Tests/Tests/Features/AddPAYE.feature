Feature: AddPAYE
	 In order to associate multiple PAYE schemes with an account
    As an account owner
    I want to be able to add new PAYE schemes attached to existing or new 
    legal entities

    @mytag
    Scenario: Manage PAYE Schemes - Add new PAYE scheme to existing legal entity
    Given I am an account account owner
    When I Add a new PAYE scheme to my existing legal entity
    Then The PAYE scheme Is added to my account

	