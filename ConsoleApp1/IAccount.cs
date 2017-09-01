namespace BankProgram
{
    public interface IAccount
    {
        bool SetName(string inName);
        string GetName();
        bool SetAddress(string inAddress);
        string GetAddress();
        void DepositFunds(decimal amount);
        bool WithdrawFunds(decimal amount);
        decimal GetBalance();
    }
}