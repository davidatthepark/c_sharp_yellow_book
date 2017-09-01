using System;

namespace BankProgram
{
    public class Account : IAccount
    {
        const decimal MAX_BALANCE = 10000000;
        const decimal MIN_BALANCE = -10000000;

        private string name;
        private string address;
        private decimal balance;

        // constructors
        public Account(string inName, string inAddress, decimal inBalance)
        {
            string errorMessage = "";

            if (SetName(inName) == false)
            {
                errorMessage = errorMessage + "Bad name: " + inName;
            }

            if (SetAddress(inAddress) == false)
            {
                errorMessage = errorMessage + "Bad name: " + inName;
            }

            if (SetBalance(inBalance) == false)
            {
                errorMessage = errorMessage = "Bad Balance: " + inBalance;
            }

            if (errorMessage != "")
            {
                throw new Exception("Account construction failed " + errorMessage); 
            }
        }

        public Account(string inName) :
            this(inName, "Not Supplied", 0)
        {
        }

        public bool SetName(string inName)
        {
            if (inName == "")
                return false;

            this.name = inName;

            return true;
        }

        public string GetName()
        {
            return name;
        }

        public bool SetAddress(string inAddress)
        {
            if (inAddress == "")
            {
                return false;
            }

            this.address = inAddress;

            return true;
        }

        public string GetAddress()
        {
            return this.address;
        }

        public bool SetBalance(decimal inBalance)
        {
            if (inBalance < MIN_BALANCE || inBalance > MAX_BALANCE)
            {
                return false;
            }

            this.balance = inBalance;

            return true;
        }

        public bool WithdrawFunds(decimal amount)
        {
            if (balance < amount)
            {
                return false;
            }

            balance = balance - amount;
            return true;
        }

        public void DepositFunds(decimal amount)
        {
            this.balance = balance + amount;
        }

        public decimal GetBalance()
        {
            return this.balance;
        }
    }
}
