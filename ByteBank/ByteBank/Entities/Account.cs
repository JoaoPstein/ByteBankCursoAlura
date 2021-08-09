using ByteBank.Validations;
using System;

namespace ByteBank.Entities
{
    public class Account
    {
        private static int OperationFee;
        public static int TotalAccount { get; private set; }
        public Client Holder { get; set; }

        public int Number { get; }
        public int Agency { get; }

        private double _balance = 100;
        public double Balance
        {
            get
            {
                return _balance;
            }
            set
            {
                if (value < 0)
                {
                    return;
                }
                _balance = value;
            }
        }

        public Account(int agency, int number)
        {
            if (number <= 0)
            {
                throw new ArgumentException("O argumento agencia deve ser maior que 0.", nameof(agency));
            }

            if (number <= 0)
            {
                throw new ArgumentException("O argumento numero deve ser maior que 0.", nameof(number));
            }

            Agency = agency;
            Number = number;

            TotalAccount++;

            OperationFee = 30 / TotalAccount;
        }

        public void Sacar(double value)
        {
            if (value < 0)
            {
                throw new ArgumentException("Valor inválido para o saque.", nameof(value));
            }

            if (_balance < value)
            {
                throw new InsufficientFundsException(Balance, value);
            }
            _balance -= value;
        }

        public void Deposit(double value)
        {
            _balance += value;
        }

        public void Transfer(double value, Account destinationAccount)
        {
            if (value < 0)
            {
                throw new ArgumentException("Valor inválido para a tranferência.", nameof(value));
            }

            Sacar(value);
            destinationAccount.Deposit(value);
        }
    }
}
