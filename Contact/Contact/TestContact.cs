using System;

class TestContact {
    static void Main()
    {
        //• Allow the user to input the number of contacts to add.
        Console.Write("Enter the total number of contacts to add: ");
        int total = Convert.ToInt32(Console.ReadLine());

        //• Create an array to store the specified number of Contact objects.
        Contact[] cnt = new Contact[total];

        //• Prompt the user to input the name and phone number for each contact and...
        for (int i = 0; i < total; i++) { 
            Console.Write("Enter the name: ");
            string name = Console.ReadLine();

            Console.Write("Enter phone number: ");
            string number = Console.ReadLine();

            Console.WriteLine();

            //store them in the array.
            cnt[i] = new Contact(name, number);
        }

        //• Provide an option to search for a contact by name and display their phone number.
        Console.Write("Enter the name to search for a contact: ");
        string search = Console.ReadLine();

        Boolean found = false;
        
        int index = 0;

        for (int i = 0; i < total; i++) {
            if (search.Equals(cnt[i].getName(), StringComparison.OrdinalIgnoreCase)) {
                found = true;
                index = i;
                
            }
        }

        if (found)
        {
            Console.WriteLine("The phone number for " + search + ": " + cnt[index].getPhoneNumber());
        }
        else {
            Console.WriteLine("The phone number is not found!!");
        }

        Console.Read();
    }
}