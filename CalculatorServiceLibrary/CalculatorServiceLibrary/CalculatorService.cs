// --------------------------------------------------------------------------------------------------------------------
// <copyright file="CalculatorService.cs" company="Aaron Morris">No Rights</copyright>
// <summary>
//   Defines the CalculatorService type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CalculatorServiceLibrary
{
    using System;

    /// <summary>The calculator service.</summary>
    public class CalculatorService : ICalculatorService
    {
        /// <summary>Add the two numbers.</summary>
        /// <param name="number1">The number 1.</param>
        /// <param name="number2">The number 2.</param>
        /// <returns>The <see cref="int"/> sum of the two numbers.</returns>
        public int Sum(int number1, int number2)
        {
            return number1 + number2;
        }

        /// <summary>Subtract the second number from the first.</summary>
        /// <param name="number1">The number 1.</param>
        /// <param name="number2">The number 2.</param>
        /// <returns>The <see cref="int"/> difference when subtracting number2 from number1.</returns>
        public int Subtract(int number1, int number2)
        {
            return number1 - number2;
        }

        /// <summary>Multiply the two numbers</summary>
        /// <param name="number1">The number 1.</param>
        /// <param name="number2">The number 2.</param>
        /// <returns>The <see cref="int"/> product of the two numbers.</returns>
        public int Multiply(int number1, int number2)
        {
            return number1 * number2;
        }

        /// <summary>Get the quotient.</summary>
        /// <param name="dividend">The dividend.</param>
        /// <param name="divisor">The divisor.</param>
        /// <returns>The <see cref="int"/> quotient.</returns>
        public int Divide(int dividend, int divisor)
        {
            if (divisor != 0)
            {
                return dividend / divisor;
            }

            return 1;
        }
    }
}
