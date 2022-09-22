using System;

namespace RefactorSOLID
{
    public class OriginalCalculator : ICalculator
    {
        public void Calculate(ICalculatorOperation operation)
        {
            if (operation is Addition)
            {
                var addition = operation as Addition;
                addition.SetResult(addition.GetLeft() + addition.GetRight());
            }
            else if (operation is Subtraction)
            {
                var subtraction = operation as Subtraction;
                subtraction.SetResult(subtraction.GetLeft() - subtraction.GetRight());
            }
            else
            {
                throw new NotImplementedException();
            }
        }
    }
}