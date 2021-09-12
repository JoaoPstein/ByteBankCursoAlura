using ByteBank.Exceptions;
using System;

namespace ByteBank.Validations
{
    public class InsufficientFundsException : OperationFinanceException
    {
        public double Saldo { get; }
        public double ValorSaque { get; }

        public InsufficientFundsException()
        {
        }

        public InsufficientFundsException(string message) : base(message)
        {
        }

        public InsufficientFundsException(double saldo, double valorSaque)
            : this($"Tentativa de saque do valor de R${valorSaque} em uma conta com saldo de R${saldo}")
        {
            Saldo = saldo;
            ValorSaque = valorSaque;
        }

        public InsufficientFundsException(string message, Exception internalException) : base(message, internalException)
        {
        }

    }
}
