using System;

namespace BankProgram
{
    class Bank
    {
        // The static keyword makes sure that the method which follows is always present.
        static void Main(string[] args)
        {
            CustomerAccount test = new CustomerAccount("Rob", 1000000);

            test.Save("Test.txt");

            CustomerAccount loaded = CustomerAccount.Load("Test.text");
            Console.WriteLine(loaded.GetName());
        }
    }
}
