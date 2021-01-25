
Feature: FirstTest
	Simple calculator for adding two numbers

@mytag
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

Scenario: open webpage example
Given i am on Billingorder page 
When i enter firstname
And i enter lastname
Then it should calculate bill
