Feature: AbleToGenerateSelect
	In order generate select statement
	As a SQL newbie
	I want to use object to give me my SQL

@select
Scenario: Simple Select From object
	Given Select Generator
	And Table is 'TestObject' 
	When Request Select for TestObject
	Then I have SQL like 'SELECT t.Id, t.Name, t.OrderId FROM TestObject t' 

@select
Scenario: Simple Select From object with alias
	Given Select Generator
	And Table with alias is 'TestObject' and alias 'to'
	When Request Select for TestObject
	Then I have SQL like 'SELECT to.Id, to.Name, to.OrderId FROM TestObject to' 

Scenario: Simple where
	Given Select Generator
	And Table is 'TestObject'
	And Where clause is equals between 'Name' and "'Test'"
	When Request Select for TestObject
	Then I have SQL like 'SELECT t.Id, t.Name, t.OrderId FROM TestObject t WHERE t.Name = 'Test''

	
Scenario: Where with simple bracket
	Given Select Generator
	And Table is 'TestObject'
	And Where clause is equals between 'Name' and "'Test'"
	And And in bracket Where is equals between 'Name' and "'Test'"
	When Request Select for TestObject
	Then I have SQL like 'SELECT t.Id, t.Name, t.OrderId FROM TestObject t WHERE t.Name = 'Test' AND (t.Name = 'Test')'