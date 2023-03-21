
namespace BtvnBai4
{
    class Program
        
    {
        public static void Main(String[] args)
        {
            Account account = new Account();
            account.FirstName = "Nam";
            account.LastName = "Nguyen";
            account.Email = "abc";
            account.Balance = 100;

            Account account1 = new CheckAccount();
            account1.FirstName = "Nam";
            account1.LastName = "Nguyen";
            account1.Email = "abc";
            account1.Balance = 100;
            /* account.Deposite(50, account.Balance);*/

            // Console.WriteLine($"{account.ToString()}");
            /*Console.WriteLine($"Total Balance When Deposite Money : {account.Deposite(account.Balance, 50)}");*/
            // Console.WriteLine($"Total Balance When With Draw Money : {account.WithDraw(account.Balance, 50)}");
            // Console.WriteLine($"Total Balance When With Draw Money : {account.GetBalance(account.Balance)}");
            Console.WriteLine($"Balacne after add fee tax : {account1.Deposite(account.Balance, 100)}");
        }
    }
}
