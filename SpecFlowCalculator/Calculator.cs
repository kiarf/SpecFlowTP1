namespace SpecFlowCalculator
{
    public class Calculator
    {
        public int FirstNumber { get; set; }
        public int SecondNumber { get; set; }

        public int Add()
        {
            return FirstNumber + SecondNumber;
        }

        public int Multiply()
        {
            return FirstNumber * SecondNumber;
        }

        public string Divide()
        {
            return SecondNumber != 0 ? (FirstNumber / SecondNumber).ToString() : "Division by 0";
        }
    }
}