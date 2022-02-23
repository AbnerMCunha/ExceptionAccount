
using System;
using System.Globalization;
using AccountTratamentoExcecoes.Entities;
using AccountTratamentoExcecoes.Entities.Exceptions;

namespace AccountTratamentoExcecoes
{
    class Program
    {
        static void Main(string[] args)
        {

            try{
                
                Console.WriteLine("Enter Account Date :  ");
                Console.Write("\nNumber : ");
                int number = int.Parse(Console.ReadLine());

                Console.Write("Holder : ");
                string holder = Console.ReadLine();

                Console.Write("Initial Balance : ");
                double InitialBalance = double.Parse(Console.ReadLine());

                Console.Write("Withdraw Limit : ");
                double withdrawLimit = int.Parse(Console.ReadLine());

                BusinessAccount businessAccount = new BusinessAccount(number, holder, InitialBalance, withdrawLimit);

                Console.Write("\nEnter Amount for withdraw : ");
                double amount = double.Parse(Console.ReadLine());

                businessAccount.Withdraw(amount);

                Console.WriteLine(businessAccount);
                Console.ReadLine();

            }
            catch (ExceptionAccount e)
            {
                Console.WriteLine("Account Error : " + e.Message);
            }
            catch (FormatException  e)
            {
                Console.WriteLine("Format Error : " + e.Message);
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected Error : " + e.Message);
            }



            /*
             * Resultado em Tela
             
             * Caso 1 - Saque Permitido.
             
                    Enter Account Date :

                    Number : 1501
                    Holder : Larry Maher
                    Initial Balance : 5000
                    Withdraw Limit : 3000

                    Enter Amount for withdraw : 2000
                    [CC]: 1501, Titular: Larry Marren, Saldo $2993.00, Limite de Empréstimo : $3000.00

            
             * Caso 3 - Saque não Permitido: Quantia maior Saldo da Conta
             
                    Enter Account Date :

                    Number : 1081
                    Holder : Jeane Floyd
                    Initial Balance : 5000
                    Withdraw Limit : 6000

                    Enter Amount for withdraw : 5500
                    Account Error : Amount above balance + tax.   
                    [CC]: 1081, Titular: Jeane Floyd, Saldo 5000.00, Limite de Empréstimo : $ 6000.00


             * Caso 3 - Saque não Permitido: Quantia maior que Limite de Saque
             
                    Enter Account Date :

                    Number : 1080
                    Holder : Jhon Mayor
                    Initial Balance : 5000
                    Withdraw Limit : 3000

                    Enter Amount for withdraw : 4000
                    Account Error : Amount is higher than your Withdraw Limit.      
                    [CC]: 1080, Titular: Jhon Mayor, Saldo 5000.00, Limite de Empréstimo : $ 3000.00

             */
        }

    }
}
