Feature: PostRequestCreateUser
	In order to verify user is created
	I need to send a post request

@mytag
Scenario: Create Single User Post Request
	Given I send post request to https://reqres.in/api/users
	When I send a post request to verify single user is created
	Then I should have response