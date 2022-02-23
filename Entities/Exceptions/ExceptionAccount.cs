using System;


namespace AccountTratamentoExcecoes.Entities.Exceptions
{
    internal class ExceptionAccount : ApplicationException
    {
        public ExceptionAccount(string? message) : base(message)
        {
        }

    }
}
