using System.Collections.Generic;
using System.Linq;

namespace SpecFlowCalculator
{
    public class Calculator
    {
        public Calculator()
        {
            Numbers = new List<int>();
            Operators = new List<char>();
        }

        public decimal FirstNumber { get; set; }
        public decimal SecondNumber { get; set; }
        public List<int> Numbers { get; set; }
        public List<char> Operators { get; set; }

        public decimal Add()
        {
            return FirstNumber + SecondNumber;
        }

        private decimal Substract()
        {
            return FirstNumber - SecondNumber;
        }

        public decimal Multiply()
        {
            return FirstNumber * SecondNumber;
        }

        public decimal AddAll()
        {
            return Numbers.Sum();
        }

        public decimal MultiplyAll()
        {
            return Numbers.Aggregate(1, (current, number) => current * number);
        }

        public string Divide()
        {
            return SecondNumber != 0 ? (FirstNumber / SecondNumber).ToString() : "Division by 0";
        }

        private decimal DivideInternal()
        {
            return FirstNumber / SecondNumber;
        }

        public string Operations()
        {
            if (Numbers.Count != (Operators.Count + 1))
            {
                return "";
            }

            var value = 0m;
            FirstNumber = Numbers[0];
            for (var i = 0; i < Numbers.Count - 1; i++)
            {
                SecondNumber = Numbers[i + 1];
                value = Operators[i] switch
                {
                    '+' => Add(),
                    '-' => Substract(),
                    '*' => Multiply(),
                    '/' => DivideInternal(),
                    _ => value
                };

                FirstNumber = value;
            }

            return value.ToString();
        }
    }
}