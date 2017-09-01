namespace BankProgram
{
    interface IBank
    {
        IAccount FindAccount(string name);
        bool StoreAccount(IAccount account);
    }
}
