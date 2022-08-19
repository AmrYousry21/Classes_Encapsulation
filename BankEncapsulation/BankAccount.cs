namespace BankEncapsulation
{
    public class BankAccount 
    {
        private double _balance = 0.0;

        public void Deposit (double num) 
        {
            this._balance += num;
           
        }

        public void GetBalance() 
        {
            Console.WriteLine($"Your balance is: {_balance}");
        }
    
    }
}
