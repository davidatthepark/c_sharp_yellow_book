using System.Collections;

namespace BankProgram
{
    class HashBank : IBank
    {
       Hashtable bankHashTable = new Hashtable();
       public IAccount FindAccount(string name)
       {
            return bankHashTable[name] as IAccount;
       }

       public bool StoreAccount(IAccount account)
       {
            bankHashTable.Add(account.GetName(), account);
            return true;
       }
    }
}
