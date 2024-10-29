namespace CalculatorApp.Classes
{
    public class MultiplyOperation : OperationBase
    {
        public override float Compute(List<float> values)
        {
            return values.Aggregate((a, b) => a * b);
        }

    }
}
