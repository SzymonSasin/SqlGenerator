Feature: AbleToGenerateSelect
	In order generate select statement
	As a SQL newbie
	I want to use object to give me my SQL

@select
Scenario: Simple Select From object
	Given Select Generator
	When Request Select for TestObject
	Then I have SQL like 'SELECT t.Id, t.Name, t.OrderId FROM TestObject t' 

@select
Scenario: Simple Select From object with alias
	Given Select Generator
	And Alias is 'to' 
	When Request Select for TestObject
	Then I have SQL like 'SELECT to.Id, to.Name, to.OrderId FROM TestObject to' 

Scenario: Simple where
	Given Select Generator
	And  where clause is 'Name = 'Test'
	When Request Select for TestObject
	Then I have SQL like 'SELECT t.Id, t.Name, t.Orderid FROM TestObject t WHERE t.Name = 'Test''