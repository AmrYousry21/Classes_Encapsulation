using System;

namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();

            Console.WriteLine("Enter ammount you wish to deposit:");
            double input = double.Parse(Console.ReadLine());

            while (input != 0)
            {

                account.Deposit(input);

                account.GetBalance();

                Console.WriteLine("Enter ammount you wish to deposit or Enter 0 to Exit:");
                input = double.Parse(Console.ReadLine());
            }
        }
    }
}
