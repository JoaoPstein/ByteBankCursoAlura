using System;

namespace ByteBank.Exceptions
{
    public class OperationFinanceException : Exception
    {
        public OperationFinanceException()
        {
                
        }

        public OperationFinanceException(string message) : base(message)
        {

        }

        public OperationFinanceException(string message, Exception internalException) : base(message, internalException)
        {

        }
    }
}
