using CalculatorApp.Interfaces;

namespace CalculatorApp.Classes
{
    public abstract class OperationBase : IOperation
    {
        public abstract float Compute(List<float> values);


    }
}
