using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace _112
{
    public class Calculator
    {
        private Equations _equations = new Equations();
        string[] _priorityOps = { "*", "/" };
        
        public string DoMath(List<string> numbers, List<string> operators)
        {
            while (operators.Count > 0)
            {
                PriorityOperators(numbers, operators);
                PlusMinusOperators(numbers, operators);
            }
            return Normalize(decimal.Parse(numbers[0])).ToString();
        }

        // Makes decimal look sensible without extra ,00000000000000000000 at tail
        public static decimal Normalize(decimal value)
        {
            return value / 1.000000000000000000000000000000000m;
        }

        private void PriorityOperators(List<string> numbers, List<string> operators)
        {
            while (ContainsPriorityOperators(operators))
                foreach (string op in operators)
                    if (_priorityOps.Contains(op))
                    {
                        CalculatePriorityOperators(numbers, op, operators.IndexOf(op));
                        ClearUsed(numbers, operators, op, operators.IndexOf(op));
                        break;
                    }
        }

        private bool ContainsPriorityOperators(List<string> operators)
        {
            return operators.Any(op => _priorityOps.Contains(op));
        }

        private void CalculatePriorityOperators(List<string> numbers, string op, int numbersIndex)
        {
            if (op == "*")
                numbers[numbersIndex] = _equations.Multiply(numbers[numbersIndex], numbers[numbersIndex + 1]);
            else // "/" operator
                try
                {
                    numbers[numbersIndex] = _equations.Divide(numbers[numbersIndex], numbers[numbersIndex + 1]);
                }
                catch (DivideByZeroException ex)
                {
                    Console.WriteLine(ex.ToString());
                }
        }

        private void PlusMinusOperators(List<string> numbers, List<string> operators)
        {
            foreach (string op in operators)
            {
                CalculatePlusMinusOperators(numbers, op, operators.IndexOf(op));
                ClearUsed(numbers, operators, op, operators.IndexOf(op));
                break;
            }
        }
        
        private void CalculatePlusMinusOperators(List<string> numbers, string op, int numbersIndex)
        {
            if (op == "+")
                numbers[numbersIndex] = _equations.Plus(numbers[numbersIndex], numbers[numbersIndex + 1]);
            else // "-" operator
                numbers[numbersIndex] = _equations.Minus(numbers[numbersIndex], numbers[numbersIndex + 1]);
        }

        private static void ClearUsed(List<string> numbers, List<string> operators, string op, int numbersIndex)
        {
            numbers.RemoveAt(numbersIndex + 1);
            operators.Remove(op);
        }

    }
}
