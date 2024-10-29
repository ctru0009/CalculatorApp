namespace CalculatorApp.Classes
{
    public class AddOperation : OperationBase
    {
        public override float Compute(List<float> values)
        {
            return values.Sum();
        }

    }
}
