using FluentAssertions;
using TechTalk.SpecFlow;

namespace SpecFlowCalculator.specs.Steps
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        private readonly Calculator _calculator = new Calculator();

        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        private readonly ScenarioContext _scenarioContext;

        private string _result;

        public CalculatorStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            _calculator.FirstNumber = number;
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            _calculator.SecondNumber = number;
        }

        [Given("the numbers are")]
        public void GivenNumbersAre(Table dataTable)
        {
            foreach (var row in dataTable.Rows)
            {
                _calculator.Numbers.Add(int.Parse(row[0]));
            }
        }

        [Given("the operators are")]
        public void GivenOperatorsAre(Table dataTable)
        {
            foreach (var row in dataTable.Rows)
            {
                _calculator.Operators.Add((row[0][0]));
            }
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            _result = _calculator.Add().ToString();
        }

        [When(@"the two numbers are mutiplied")]
        public void WhenTheTwoNumbersAreMutiplied()
        {
            _result = _calculator.Multiply().ToString();
        }

        [When(@"all numbers are added")]
        public void WhenAllNumbersAreAdded()
        {
            _result = _calculator.AddAll().ToString();
        }

        [When(@"all numbers are multiplied")]
        public void WhenAllNumbersAreMultiplied()
        {
            _result = _calculator.MultiplyAll().ToString();
        }

        [When(@"the two numbers are divided")]
        public void WhenTheTwoNumbersAreDivided()
        {
            _result = _calculator.Divide();
        }

        [When(@"a number is divided by zero")]
        public void WhenANumberIsDividedByZero()
        {
            _result = _calculator.Divide();
        }

        [When(@"operation")]
        public void Operation()
        {
            _result = _calculator.Operations();
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(string result)
        {
            _result.Should().Be(result);
        }
    }
}