using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsCalculatorAPI
{
    public class MarsCalculator
    {
        /// <summary>
        /// Adding one number to another.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public string Add(string num1, string num2)
        {
            int octalNum1 = Convert.ToInt32(num1, 8);
            int octalNum2 = Convert.ToInt32(num2, 8);
            return Convert.ToString(octalNum1 + octalNum2, 8);
        }

        /// <summary>
        /// Substracting one number from another.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public string Substract (string num1, string num2)
        {
            int octalNum1 = Convert.ToInt32(num1, 8);
            int octalNum2 = Convert.ToInt32(num2, 8);
            return Convert.ToString(octalNum1 - octalNum2, 8);
        }

        /// <summary>
        /// Multiply two numbers.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public string Multiply (string num1, string num2)
        {
            int octalNum1 = Convert.ToInt32(num1, 8);
            int octalNum2 = Convert.ToInt32(num2, 8);
            return Convert.ToString(octalNum1 * octalNum2, 8);
        }

        /// <summary>
        /// Dividing a number by another.
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        public string Divide (string num1, string num2)
        {
            int octalNum1 = Convert.ToInt32(num1, 8);
            int octalNum2 = Convert.ToInt32(num2, 8);
            return Convert.ToString(octalNum1 + octalNum2, 8);
        }
    }
}
