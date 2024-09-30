Feature: Registration

This feature demonstrates the user registration 

@registration
Scenario: User Registration
	Given the user navigates to the user registration page
	When the user fills the forms and submits
	Then the success message is displayed
