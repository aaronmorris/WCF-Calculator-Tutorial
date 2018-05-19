// --------------------------------------------------------------------------------------------------------------------
// <copyright file="ICalculatorService.cs" company="Aaron Morris">No rights</copyright>
// <summary>
//   Defines the IService1 type.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace CalculatorServiceLibrary
{
    using System.Runtime.Serialization;
    using System.ServiceModel;

    /// <summary>
    /// The CalculatorService interface.
    /// </summary>
    [ServiceContract]
    public interface ICalculatorService
    {
        /// <summary>Sum the two numbers</summary>
        /// <param name="number1">The first number to add</param>
        /// <param name="number2">The second number to add</param>
        /// <returns>The <see cref="int"/> sum of the two numbers.</returns>
        [OperationContract]
        int Sum(int number1, int number2);

        /// <summary>Subtract the second number from the first.</summary>
        /// <param name="number1">The first number.</param>
        /// <param name="number2">The second number.</param>
        /// <returns>The <see cref="int"/> difference of the two numbers.</returns>
        [OperationContract]
        int Subtract(int number1, int number2);

        /// <summary>Multiply the two numbers</summary>
        /// <param name="number1">The first number.</param>
        /// <param name="number2">The second number.</param>
        /// <returns>The <see cref="int"/> product of the two numbers.</returns>
        [OperationContract]
        int Multiply(int number1, int number2);

        /// <summary>Divide the two numbers.</summary>
        /// <param name="dividend">The dividend.</param>
        /// <param name="divisor">The divisor.</param>
        /// <returns>The <see cref="int"/> quotient result.</returns>
        [OperationContract]
        int Divide(int dividend, int divisor);
    }

    // Use a data contract as illustrated in the sample below to add composite types to service operations.
    // You can add XSD files into the project. After building the project, you can directly use the data types defined there, with the namespace "CalculatorServiceLibrary.ContractType".
    [DataContract]
    public class CompositeType
    {
        bool boolValue = true;
        string stringValue = "Hello ";

        [DataMember]
        public bool BoolValue
        {
            get { return boolValue; }
            set { boolValue = value; }
        }

        [DataMember]
        public string StringValue
        {
            get { return stringValue; }
            set { stringValue = value; }
        }
    }
}
