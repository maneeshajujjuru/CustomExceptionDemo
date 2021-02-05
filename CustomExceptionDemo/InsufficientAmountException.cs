using System;
using System.Collections.Generic;
using System.Text;

namespace CustomExceptionDemo
{
    /// <summary>
    /// Insufficient Amount Exception
    /// </summary>
    public class InsufficientAmountException : System.ApplicationException
    {
        private static readonly string DefaultMessage = "Account balance is insufficient for the transaction.";

        public InsufficientAmountException() : base(DefaultMessage) { }

    }
}
