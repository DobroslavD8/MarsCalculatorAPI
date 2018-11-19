using MarsCalculatorAPI;
using MarsCalculatorAPI.Exceptions;
using System;

namespace MarsCalculatorApplication
{
    class Program
    {
        /// <summary>
        /// Entering the numbers and math operator.
        /// </summary>
        ///
        static void Main()
        {
            MarsCalculator mars = new MarsCalculator();

            Console.Write("Enter first number: ");
            string firstNumber = Console.ReadLine();

            Console.Write("Enter second number: ");
            string secondNumber = Console.ReadLine();

            Console.Write("Enter operator: ");
            string oper = Console.ReadLine();

            // Action determination      
            try
            {
                if (oper == "+")
                {
                    string plus = mars.Add(firstNumber, secondNumber);
                    Console.WriteLine("The result is: {0}.", plus);
                }
                else if (oper == "-")
                {
                    string substr = mars.Substract(firstNumber, secondNumber);
                    Console.WriteLine("The result is: {0}.", substr);
                }
                else if (oper == "*")
                {
                    string multi = mars.Multiply(firstNumber, secondNumber);
                    Console.WriteLine("The result is: {0}.", multi);
                }
                else if (oper == "/")
                {
                    string dvd = mars.Divide(firstNumber, secondNumber);
                    Console.WriteLine("The result is: {0}.", dvd);
                }
                else
                {
                    Console.WriteLine("Enter valid operator!");
                }
            }
            catch(MarsCalcException ex)
            {
                Console.WriteLine("Error in caltulating: " + ex.Message);
            }
            catch(Exception)
            {
                Console.WriteLine("Unknown Error!");
            }
           


           /* string addition = mars.Add("5", "5");
            Console.WriteLine("Addition 5 and 5. Result: {0}. \n", addition);

            string substract = mars.Substract("7", "5");
            Console.WriteLine("Substract 7 and 5.Result: {0}. \n", substract);

            string multiply = mars.Multiply("10", "5");
            Console.WriteLine("Multiply 10 and 5. Result: {0}. \n", multiply);

            string divide = mars.Divide("25", "5");
            Console.WriteLine("Divide 25 and 5. Result: {0}. \n", divide);
            */

        }
    }
}
