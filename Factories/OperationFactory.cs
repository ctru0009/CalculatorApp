using CalculatorApp.Classes;
using CalculatorApp.Interfaces;

namespace CalculatorApp.Factories
{
    public class OperationFactory
    {
        public static IOperation CreateOperation(string operationType)
        {
            switch (operationType)
            {
                case "add":
                    return new AddOperation();
                case "subtract":
                    return new SubtractOperation();
                case "multiply":
                    return new MultiplyOperation();
                case "divide":
                    return new DivideOperation();
                default:
                    return null;
            }
        }
    }
}
