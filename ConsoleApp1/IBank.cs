namespace ConsoleApp1
{
    partial class bank
    {
        interface IBank
        {
            IAccount FindAccount(string name);
            bool StoreAccount(IAccount account);
        }
    }
}
