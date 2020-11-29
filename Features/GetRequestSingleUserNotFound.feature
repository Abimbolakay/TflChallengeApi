Feature: GetRequestSingleUserNotFound
	In order to verify no user is found
	I need to send a get request

@mytag
Scenario: Single User Not found Get Request
	Given I send a get request to https://reqres.in/api/users/23
	When I send a get request to verify no single user found
	Then I should recieve a response