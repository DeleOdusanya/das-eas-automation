Feature: Create A Das Account
    As an Employer
    I would like the ability to register an Account
    So that I can start using the Digital Apprenticeship Service

	Scenario: Registering an Account with valid details and mandatory data items have been supplied
	Given I navigate to the Create Account page 
	When I submit the form with the mandatory data items supplied
	#And I submit the activation code recieved as a consequence of a successful form submission
	#Then a DAS account will be created

    Scenario: Attempting to create an Account when the mandatory data items have not been supplied
    Given I navigate to the Create Account page 
    When I attempt to submit a form without completing the mandatory data items 
    Then validation messages will be displayed on all incomplete mandatory items

    Scenario: Registering an Account with invalid data items 
    Given I navigate to the Create Account page
    When I attempt to submit a form with invalid data items 
    Then I will be presented with an appropriate validation message

    Scenario: Registering an account with e-mail address that is already associated to an Active Account
    Given I navigate to the Create Account page
    When I submit form with e-mail address already associated to an Active Account
    Then I will be informed that the email address is already associated
    And I should remain on the account creation page

	#Scenario: Registering an account with email associated to a user that is Pending Activation
    #Given I navigate to the Create Account page
    #When I submit a form with an e-mail address associated to a user that is Pending Activation 
    #Then a new account should be created
    #And all other information provided in this step should supersede information provided historically

	
    #Scenario: Activation code should expire midnight, 7 days after the Account is created
    #Given I navigate to the Create Account page
    #When I submit form with valid data in all mandatory fields
    #Then I should receive an activation code via email
    #And activation code should be valid for 7 days
