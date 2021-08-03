using System;

namespace ByteBank.Entities
{
    public class Account
    {
        private static int OperationFee;
        public static int TotalAccount { get; private set; }
        public Client Holder { get; set; }

        public int Number { get; set; }
        public int Agency { get; set; }

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

            OperationFee = 30 / TotalAccount;

            TotalAccount++;
        }

        public bool Sacar(double value)
        {
            if (_balance < value)
            {
                return false;
            }
            _balance -= value;
            return true;
        }

        public void Deposit(double value)
        {
            _balance += value;
        }

        public bool Transfer(double value, Account destinationAccount)
        {
            if (_balance < value)
            {
                return false;
            }

            _balance -= value;
            destinationAccount.Deposit(value);
            return true;
        }
    }
}
