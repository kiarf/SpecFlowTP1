Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowCalculator.specs/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@Addition
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

@Multiplication
Scenario: Multiply two numbers
	Given the first number is 5
	And the second number is 7
	When the two numbers are mutiplied
	Then the result should be 35

@Division
Scenario: Divide two numbers
	Given the first number is 85
	And the second number is 5
	When the two numbers are divided
	Then the result should be 17

@DivisionByZero
Scenario: Divide a number by zero
	Given the first number is 17
	And the second number is 0
	When a number is divided by zero
	Then the result should be Division by 0

@MultipleAddition
Scenario: Add n numbers
	Given the numbers are
	|number|
	|2|
	|4|
	|7|
	When all numbers are added
	Then the result should be 13

@MultipleMultiplication
Scenario: Multiply n numbers
	Given the numbers are
	|number|
	|2|
	|4|
	|7|
	When all numbers are multiplied
	Then the result should be 56

	@Operations
Scenario: Operate n numbers
	Given the numbers are
	|number|
	|2|
	|4|
	|7|
	Given the operators are
	|operator|
	|+|
	|-|
	When operation
	Then the result should be -1


