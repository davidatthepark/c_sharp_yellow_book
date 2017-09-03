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
}
