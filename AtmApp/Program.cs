using Atmachine;

namespace Atmachine
{
    class Program
    {
        static void Main(string[] args)
        {
            double initialBalance = 5000; 
            BankAccount account = new BankAccount(initialBalance);

            Console.WriteLine("Welcome to the ATM!");
            Console.WriteLine($"Your initial balance: $ {account.GetBalance():N2}");

            
            account.Deposit(1000);
            Console.WriteLine($"New balance after deposit: $ {account.GetBalance():N2}");

            
            bool success = account.Withdraw(2000);
            if (success)
                Console.WriteLine($"New balance after withdrawal: $ {account.GetBalance():N2}");

            
            account.Withdraw(10000); 

            Console.ReadKey();
        }
    }
}
