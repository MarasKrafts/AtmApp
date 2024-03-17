using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atmachine
{
    public class cardHolder
    {
        string cardNum;
        int pin;
        string firstName;
        string lastName;
        double balance;

        public cardHolder(string cardNum, int pin, string firstName, string lastName, double balance) 
        {
            this.cardNum = cardNum; 
            this.pin = pin;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
        }

        public string getNum()
        {
            return cardNum;
        }

        public int getPin()
        {
            return pin;
        }

        public string getFirstName()
        {
            return firstName;
        }

        public string getLastName()
        {
            return lastName;
        }

        public double getBalance()
        {
            return balance;
        }

        public void setNum (string newCardNum)
        {
            cardNum = newCardNum;
        }

        public void setPin (int newPin)
        {
            pin = newPin;
        }

        public void setFirstName (string newFirstName)
        {
            firstName = newFirstName;
        }

        public void setLastName (string newLastName)
        {
            lastName = newLastName;
        }

        public void setBalance (double newBalance)
        {
            balance = newBalance;
        }

        void deposit (cardHolder currentUser)
        {
            Console.WriteLine("How much would you like to deposit? ");
            double deposit = double.Parse(Console.ReadLine());
            currentUser.setBalance(deposit + balance);
            Console.WriteLine("Thank you for using Mara's ATM. Your new balance is: " + currentUser.getBalance());
        }

        void withdraw (cardHolder currentUser)
        {
            Console.WriteLine("How much would you like to withdraw? ");
            double withdrawal = double.Parse(Console.ReadLine());

            if (currentUser.getBalance() < withdrawal)
            {
                Console.WriteLine("Insufficient Balance...");
            }
            else
            {
                currentUser.setBalance(currentUser.getBalance() - withdrawal);
                Console.WriteLine("Withdrawal successful. Thank you for using Mara's ATM");
            }
        }

        void balance(cardHolder currentUser)
        {
            Console.WriteLine("Current balance is: " + currentUser.getBalance());
        }

        public void CardHolderList()
        {
            List<cardHolder> cardHolders = new List<cardHolder>();
            cardHolders.Add(new cardHolder("4532123456789012", 1234, "Precious", "Emeka", 500.234));
            cardHolders.Add(new cardHolder("5123456789012345", 5678, "Tina", "George", 800.397));
            cardHolders.Add(new cardHolder("378282246310005", 5432, "Jack", "Simon", 50.500));
            cardHolders.Add(new cardHolder("6011123456789012", 9876, "Mark", "Millan", 200.357));
            cardHolders.Add(new cardHolder("3056789012345678", 3254, "Lincoln", "Steve", 100.050));
        }
    }
}
