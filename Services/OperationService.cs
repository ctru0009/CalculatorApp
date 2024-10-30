using CalculatorApp.Factories;
using CalculatorApp.Interfaces;
using CalculatorApp.Models;

namespace CalculatorApp.Services
{
    public class OperationService : ICalculate
    {
        public List<float> Calculate(Rootobject rootobject)
        {
            var results = new List<float>();

            foreach (var operation in rootobject.Maths.Operation)
            {
                // Get the operation type and values
                var operationType = operation.ID ?? throw new InvalidOperationException("Invalid operation type");

                if (operation.Value == null || operation.Value.Length == 0)
                {
                    throw new InvalidOperationException("Invalid operation values");
                }

                var operationValues = new List<float>();

                foreach (var value in operation.Value)
                {
                    if (!float.TryParse(value, out var floatValue))
                    {
                        throw new InvalidOperationException("Invalid operation value");
                    }

                    operationValues.Add(floatValue);
                }

                // Create the operation instance
                var operationInstance = OperationFactory.CreateOperation(operationType) ?? throw new InvalidOperationException("Invalid operation type");

                // Compute the result
                var result = operationInstance.Compute(operationValues);

                // Add the result to the list
                results.Add(result);
            }
            return results;
        }
    }
}
