using System;

namespace CustomExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account("Raj", 150);
            try
            {
                //Debit 200 from account
                account.Debit(200);
            }
            catch (InsufficientAmountException ex)
            {
                Console.WriteLine("Encountered exception \nException Message: " + ex.Message);
            }

            Console.Read();
        }
    }
}

