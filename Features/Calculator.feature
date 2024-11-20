Feature: Calculator

Simple calculator for adding two numbers

@mytag
Scenario: Add two numbers
	Given the tenant id is set
	When an http request is made
	Then the next step should execute