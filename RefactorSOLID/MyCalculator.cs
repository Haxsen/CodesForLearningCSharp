using System;

namespace RefactorSOLID
{
    public class MyCalculator : ICalculator
    {
        public void Calculate(ICalculatorOperation operation)
        {
            switch (operation)
            {
                case Addition addition:
                    addition?.SetResult(addition.GetLeft() + addition.GetRight());
                    break;
                
                case Subtraction subtraction:
                    subtraction?.SetResult(subtraction.GetLeft() + subtraction.GetRight());
                    break;
                
                default:
                    throw new NotImplementedException();
            }
        }
    }
}