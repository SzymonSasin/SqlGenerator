Feature: AbleToGenerateSelect
	In order generate select statement
	As a SQL newbie
	I want to use object to give me my SQL

@mytag
Scenario: Simple Select From object
	Given Select Generator
	When Request Select for TestObject
	Then I have SQL like 'SELECT t.Id, t.Name, t.OrderId FROM TestObject t' 
