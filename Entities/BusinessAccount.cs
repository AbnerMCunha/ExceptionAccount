using System;
using System.Globalization;
using System.Collections.Generic;
using AccountTratamentoExcecoes.Entities.Exceptions;

namespace AccountTratamentoExcecoes.Entities.Exceptions
{
    internal class BusinessAccount : Account
    {
        public double WithdrawLimit { get; set; }

        public BusinessAccount() : base()
        {
        }

        public BusinessAccount(int number, string holder, double balance, double withdrawLimit)
            : base(number, holder, balance)
        {
            WithdrawLimit = withdrawLimit;
        }

        public void Loan(double amount)
        {
            Balance += amount;
        }

        public override void Withdraw(double amount)
        {

            if (Balance < amount + 2)
            {
                throw new ExceptionAccount("Amount above balance + tax.");
            }
         
            if (amount > WithdrawLimit)
            {
                throw new ExceptionAccount("Amount is higher than your Withdraw Limit.");
            }

            base.Withdraw(amount + 2);
        }



        public override string ToString()
        {
            return base.ToString() + ", Limite de Empréstimo : $"
                + WithdrawLimit.ToString("F2", CultureInfo.InvariantCulture)
                ;
        }


    }
}
