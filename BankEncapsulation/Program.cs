namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();

            Console.WriteLine("Welcome to the TrueCoders Bank Simulation Main Menu.");
            Console.WriteLine("Please select whether you would like to View Banking Options or End Current Session.");
            Console.WriteLine("View Banking Options || End Current Session");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine();
            var userInput = Console.ReadLine();
            var newInput = userInput.ToLower();

            if (newInput.Contains("end"))
            {
                Console.WriteLine("Thank You. Have a wonderful day!");
            }
            else
            {
                Console.WriteLine("Please select whether you would like to make a Deposit or View your current Balance:");
                Console.WriteLine("Deposit || View Balance");
                Console.WriteLine("-----------------------");
                Console.WriteLine();
                var response = Console.ReadLine();
                var newResponse = response.ToLower();

                if (newResponse.Contains("deposit"))
                {
                    Console.WriteLine("Please write how much you would like to deposit:");
                    var deposit = double.Parse(Console.ReadLine());

                    account.Deposit(deposit);
                    Console.WriteLine("Thank You for your deposit!");
                    Console.WriteLine($"Your new balance is ${account.GetBalance()}.");
                }
                else if (newResponse.Contains("view"))
                {
                    Console.WriteLine($"Your current balance is ${account.GetBalance()}.");
                }
            }
        }
    }
}
