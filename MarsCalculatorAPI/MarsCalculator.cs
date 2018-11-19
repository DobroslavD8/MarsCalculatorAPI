using MarsCalculatorAPI.Exceptions;
using NLog;
using System;

namespace MarsCalculatorAPI
{
    /// <summary>
    /// Mars calculator with math operations.
    /// </summary>
    public class MarsCalculator
    {
        /// <summary>
        /// Adding one number to another.
        /// </summary>
        /// <param name="first Number"></param>
        /// <param name="second Number"></param>
        /// <returns></returns>
        public string Add(string num1, string num2)
        {
            int octalNum1 = GetOctalNum1(num1);
            int octalNum2 = GetOctalNum1(num2);
            return Convert.ToString(octalNum1 + octalNum2, 8);
        }

        /// <summary>
        /// Substracting one number from another.
        /// </summary>
        /// <param name="first number"></param>
        /// <param name="second number"></param>
        /// <returns></returns>
        public string Substract(string num1, string num2)
        {
            int octalNum1 = GetOctalNum1(num1);
            int octalNum2 = GetOctalNum1(num2);
            return Convert.ToString(octalNum1 - octalNum2, 8);
        }

        /// <summary>
        /// Multiply two numbers.
        /// </summary>
        /// <param name="first number"></param>
        /// <param name="second number"></param>
        /// <returns></returns>
        public string Multiply(string num1, string num2)
        {
            int octalNum1 = GetOctalNum1(num1);
            int octalNum2 = GetOctalNum1(num2);
            return Convert.ToString(octalNum1 * octalNum2, 8);
        }

        /// <summary>
        /// Dividing a number by another.
        /// </summary>
        /// <param name="first number"></param>
        /// <param name="second number"></param>
        /// <returns></returns>
        public string Divide(string num1, string num2)
        {
            int octalNum1 = GetOctalNum1(num1);
            int octalNum2 = GetOctalNum1(num2);
            return Convert.ToString(octalNum1 / octalNum2, 8);
        }

        /// <summary>
        /// Getting an octal number.
        /// </summary>
        /// <param name="first number"></param>
        /// <returns></returns>
        private int GetOctalNum1(string num1)
        {
            try
            {
                return Convert.ToInt32(num1, 8);
            }
            catch(Exception ex)
            {
                Logger logger = LogManager.GetCurrentClassLogger();
                logger.Error(ex, "Invalid octal number!");
                throw new MarsCalcException("Invalid octal number.");
            }
        }
    }
}
