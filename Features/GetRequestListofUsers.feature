Feature: GetRequestListofUsers
	In order to verify a list of users
	I need to send a get request

@mytag
Scenario: List Of Users Get Request
	Given I send a get request to https://reqres.in/api/users?page=2
	And I send a get request to verify a list of users
	When the response is received
	Then I will receive an "OK" response