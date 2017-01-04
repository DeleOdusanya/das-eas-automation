Feature: InviteTeamMember

    In order to increase the size of my team
    As an account owner
    I want to be able to add more people

Scenario: Add team member
    Given I am an account account owner
    When I invite a team member with valid email address and name
    Then A user invite is sent

Scenario: Resend Invite
    Given I am an account account owner
    When I invite a team member
	And I click resend invite
	Then Invite should be resent 
	
Scenario: Cancel invite and confirm cancellation
    Given I am an account account owner
    When I invite a team member
	And I click cancel invite
	And I confirm cancellation
	Then Invite should be cancelled 
	And member invite removed from page

Scenario: Cancel invite but don't confirm cancellation
    Given I am an account account owner
    When I invite a team member
	And I click cancel invite
	And I selelect NO don't cancel
	Then Invite should NOT be cancelled 
	
Scenario: View team members
    Given I am an account account owner
    Then I should be able to view team members

Scenario: Delete team members
    Given I am an account account owner
    When I delete a team member
	Then team member is removed from list

   


     

