namespace CalculatorApp.Classes
{
    public class DivideOperation : OperationBase
    {
        public override float Compute(List<float> values)
        {
            float result = values[0];
            for (int i = 1; i < values.Count; i++)
            {
                if (values[i] == 0)
                {
                    throw new DivideByZeroException();
                }
                result /= values[i];
            }
            return result;
        }
    }
}
