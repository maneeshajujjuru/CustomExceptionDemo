using System;
using System.Collections.Generic;
using System.Text;

namespace CustomExceptionDemo
{
    class Account
    {
        #region Constructor
        public Account(string name, int balance)
        {
            Name = name;
            Balance = balance;
        }

        #endregion Constructor

        #region public properties

        /// <summary>
        /// Name
        /// </summary>
        public string Name { get; private set; }

        /// <summary>
        /// Account balance
        /// </summary>
        public int Balance { get; private set; }

        #endregion public properties

        #region Debit

        /// <summary>
        /// Debit amount from account
        /// </summary>
        /// <param name="amount">Debit amount</param>
        public void Debit(int amount)
        {
            // if debited amount is less than account balance throw exception
            if (Balance < amount) throw new InsufficientAmountException();
            Balance = Balance - amount;
        }

        #endregion Debit

    }

}
