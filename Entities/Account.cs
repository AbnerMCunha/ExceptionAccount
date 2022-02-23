using System;
using System.Globalization;
using AccountTratamentoExcecoes.Entities.Exceptions;

namespace AccountTratamentoExcecoes
{
    internal abstract class Account
    {

        //Os atributos estão como Protected Set para só serem poderem ser alterados pela (sub)classes derivadas de Account
        public int Number { get; protected set; }

        public string Holder { get; protected set; }

        public double Balance { get; protected set; }

        public Account()
        {
        }

        public Account(int number, string holder, double balance)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
        }

        public virtual void Withdraw(double amount)
        {
            if (Balance < amount + 5)
            {
                throw new ExceptionAccount("Amount above balance + tax.");
            }

            Balance -= amount + 5;

        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }


        public override string ToString()
        {
            return "[CC]: " + Number.ToString() + ", Titular: " + Holder + ", Saldo $" + Balance.ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
