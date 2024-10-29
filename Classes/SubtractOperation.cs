namespace CalculatorApp.Classes
{
    public class SubtractOperation : OperationBase
    {
        public override float Compute(List<float> values)
        {
            float result = values[0];
            for (int i = 1; i < values.Count; i++)
            {
                result -= values[i];
            }
            return result;
        }
    }
}
