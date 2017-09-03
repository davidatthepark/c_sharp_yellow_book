namespace BankProgram
{
    public interface IAccount
    {
        string GetName();
        void DepositFunds(decimal amount);
        bool WithdrawFunds(decimal amount);
        decimal GetBalance();
    }
}