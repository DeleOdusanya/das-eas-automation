﻿Feature: RemovePAYE
	As an Account owner I should be able to remove PAYE

@mytag
Scenario: Manage PAYE Schemes - As an Account owner I should be able to remove PAYE
	Given I am an account account owner
	When I Remove a PAYE scheme from my account
    Then The PAYE scheme should be removed from my account

Scenario: Manage PAYE Schemes - As an account viewer I should NOT be able to Remove PAYE
	Given I am an account viewer owner
	When I Remove a PAYE scheme from my account
    Then The PAYE scheme should NOT be removed from my account

Scenario: Manage PAYE Schemes - As an account Transactor I should NOT be able to Remove PAYE
	Given I am an account viewer owner
	When I Remove a PAYE scheme from my account
    Then The PAYE scheme should NOT be removed from my account