using System;
using System.Xml.Linq;
class TestAccountDriver
{
    static void Main()
    {
        //• Allow the user to input the number of accounts to manage.
        Console.Write("Enter the total number of accounts to manage: ");
        int total = Convert.ToInt32(Console.ReadLine());

        //• Create an array to store the specified number of Account objects.
        Account[] acc = new Account[total];

        //• For each account, prompt the user to input the account number and initial balance and
        for (int i = 0; i < acc.Length; i++) {
            Console.Write("Enter the account number: ");
            string number = Console.ReadLine();

            Console.Write("Enter the initial balance: ");
            double balance = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            //  store them in the corresponding Account object.
            acc[i] = new Account(number, balance);
        }

        //• Provide options to deposit and withdraw funds from an account.
        Console.Write("Enter 'D' to deposit of 'W' to withdram: ");
        string option = Console.ReadLine();

        Console.Write("Enter account number: ");
        string accNumber = Console.ReadLine();

        Console.Write("Enter amount: ");
        double amount = Convert.ToDouble(Console.ReadLine());

        double newBalance = 0;

        if (option.Equals("D", StringComparison.OrdinalIgnoreCase)) {

            for (int i = 0; i < acc.Length; i++)
            {
                if (accNumber.Equals(acc[i].getAccountNumber())) {

                    newBalance = acc[i].getBalance() + amount;

                    //update the new balance on the main class
                    acc[i].setBalance(newBalance);

                    //Display netification
                    Console.WriteLine("Dipsited: R" + amount + "\nAvailable balance: R" + acc[i].getBalance());
                }
            }

        } else if (option.Equals("W", StringComparison.OrdinalIgnoreCase)) { 
            
            for (int i = 0;i < acc.Length; i++)
            {
                if (accNumber.Equals(acc[i].getAccountNumber())) {

                    newBalance = acc[i].getBalance() - amount;

                    //update the new balance on the main class
                    acc[i].setBalance(newBalance);

                    //Display the notification
                    Console.WriteLine("Cash withdraw: R" + amount + "\nAvailable balance: " + acc[i].getBalance());
                }
            }

        }


        //• Display the balance of all accounts.
        Console.WriteLine("\tThe balance of all accounts.");

        for (int i = 0; i < acc.Length ; i++)
        {
            Console.WriteLine(acc[i].toString());
        }


        Console.Read();
    }
}