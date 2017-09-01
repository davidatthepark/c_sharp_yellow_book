using System;

namespace BankProgram
{

    class Bank
    {
        // The static keyword makes sure that the method which follows is always present.
        static void Main(string[] args)
        {
            ArrayBank ourBank = new ArrayBank(100);

            Account newAccount = new Account("Rob", "Robs House", 1000000);

            if (ourBank.StoreAccount(newAccount) == true)
            {
                Console.WriteLine("Account added to bank");
            }

            IAccount storedAccount = ourBank.FindAccount("Rob");
            if (storedAccount != null)
            {
                Console.WriteLine("Account found in bank");
            }
        }
    }
}
