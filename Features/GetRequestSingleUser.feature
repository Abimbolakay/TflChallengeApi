Feature: GetRequestSingleUser
	In order to verify a get request 
	I need to get the details of a single user


@mytag
Scenario: Single user Details Get Request
	Given I send a GET request to https://reqres.in/api/users/2
	And I send a GET request to enquire a single user details
	When the reply is received
	Then I should get a status code OK