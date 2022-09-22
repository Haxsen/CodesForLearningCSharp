namespace RefactorSOLID
{
    public class Subtraction : ICalculatorOperation
    {
        private double left, right, result;

        public double GetLeft() => left;
        public double GetRight() => right;

        public void SetResult(double value)
        {
            result = value;
        }

        public double GetResult()
        {
            return result;
        }
    }
}