namespace BankProgram
{
    class ArrayBank
    {
        IAccount[] accounts;

        // constructors
        public ArrayBank(int bankSize)
        {
            accounts = new IAccount[bankSize];
        }

        public bool StoreAccount(IAccount account)
        {
            int position = 0;
            for (position = 0; position < accounts.Length; position++)
            {
                if (accounts[position] == null)
                {
                    accounts[position] = account;
                    return true;
                }
            }

            return false;
        }

        public IAccount FindAccount(string name)
        {
            int position = 0;
            for (position = 0; position < accounts.Length; position++)
            {
                if (accounts[position] == null)
                {
                    continue;
                }
                if (accounts[position].GetName() == name)
                {
                    return accounts[position];
                }
            }

            return null;
        }
    }
}
