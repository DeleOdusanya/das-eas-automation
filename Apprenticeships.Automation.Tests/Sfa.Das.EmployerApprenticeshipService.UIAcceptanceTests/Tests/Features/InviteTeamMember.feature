Feature: InviteTeamMember

    In order to increase the size of my team
    As an account owner
    I want to be able to add more people

Scenario: Manage Team Member - Add team member
    Given I am an account account owner
    When I invite a team member with valid email address and name
    Then A user invite is sent

Scenario: Manage Team Member - Resend Invite
    Given I am an account account owner
    When I invite a team member
	And I click resend invite
	Then Invite should be resent 
	
Scenario: Manage Team Member - Cancel invite and confirm cancellation
    Given I am an account account owner
    When I invite a team member
	And I click cancel invite
	And I confirm cancellation
	Then Invite should be cancelled 
	And member invite removed from page

Scenario: Manage Team Member - Cancel invite but don't confirm cancellation
    Given I am an account account owner
    When I invite a team member
	And I click cancel invite
	And I selelect NO don't cancel
	Then Invite should NOT be cancelled 
	
Scenario: Manage Team Member - View team members
    Given I am an account account owner
    Then I should be able to view team members

Scenario: Manage Team Member - Delete team members
    Given I am an account account owner
    When I delete a team member
	Then team member is removed from list

   


     

