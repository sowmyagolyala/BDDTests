Feature: LoginPageTests
	As a user of Mypeoplemanager application I should be able to login successfully

@mytag
Scenario: Successful Login 
	Given I'm on Login page
	And I have entered valid username and password
	When I hit login button 
	Then I should login successfully

Scenario: Successful Logout
     When user hits Signout button 
	 Then user should logout Successfully


