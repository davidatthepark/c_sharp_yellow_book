using System;
using System.Collections.Generic;

namespace BankProgram
{
    class DictionaryBank
    {
        Dictionary<string, IAccount> accountDictionary = new Dictionary<string, IAccount>();

        public IAccount FindAccount(string name)
        {
            if (accountDictionary.ContainsKey(name))
                return accountDictionary[name];
            else
                return null;
        }

        public bool StoreAccount(IAccount account)
        {
            if (accountDictionary.ContainsKey(account.GetName()))
            {
                return false;
            }

            accountDictionary.Add(account.GetName(), account);
            return true;
        }
    }

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
