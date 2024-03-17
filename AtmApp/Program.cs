using Atmachine;

namespace Atmachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MaraATM");
            Thread.Sleep(3000);

            void printOptions()
            {
                Console.WriteLine("Please chose from one of the following opions...");
                Console.WriteLine("1. Deposit");
                Console.WriteLine("2. Withdraw");
                Console.WriteLine("3. Show Balance");
                Console.WriteLine("4. Exit");
            }

        }
    }
}
