Feature: PutRequestUpdateSingleUser
	In order to verify a single user post is updated
	I need to send a put request

@mytag
Scenario: Update Single User Put Request
	Given I send a put request to https://reqres.in/api/users/2
	When I send a put request to verify single user post is updated
	Then I should recieve a response sent to me