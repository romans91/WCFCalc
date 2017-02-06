using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WCFCalcService
{
    public class CalcService : ICalcService
    {
        /// <summary>
        /// Applies the operator on two inputs.
        /// </summary>
        /// <param name="operandA">String contents value of left text box from the client</param>
        /// <param name="operandB">String contents value of right text box from the client</param>
        /// <param name="op">Character representation of arithmetic operator</param>
        /// <returns></returns>
        public string PerformOperation(string operandA, string operandB, char op)
        {
            bool operandParseSuccessful = false;

            if (String.IsNullOrEmpty(operandA))
            {
                operandA = "0";
            }
            if (String.IsNullOrEmpty(operandB))
            {
                operandB = "0";
            }

            try
            {
                decimal a = Convert.ToDecimal(operandA);
                decimal b = Convert.ToDecimal(operandB);
                operandParseSuccessful = true;

                switch (op)
                {
                    case '+':
                        return (a + b).ToString();
                    case '-':
                        return (a - b).ToString();
                    case '*':
                        return (a * b).ToString();
                    case '/':
                        return (a / b).ToString();
                    case '%':
                        return (a % b).ToString();
                    case '^':
                        string result = Math.Pow(Convert.ToDouble(a), Convert.ToDouble(b)).ToString();
                        result = (result.Equals("Infinity"))
                            ? "Operand value(s) too large for exponential function to be carried out"
                            : result;
                        return result;
                    default:
                        return "Invalid operator: " + op;
                }
            }
            catch (FormatException e)
            {
                return "Invalid operand";
            }
            catch (OverflowException e)
            {
                if (operandParseSuccessful) return "Result value too large to display";
                return "Operand value(s) too large to fit inside decimal";
            }
            catch (DivideByZeroException e)
            {
                if (op == '%') return "Cannot mod by zero";
                    return "Cannot divide by zero";
            }
        }
    }
}
