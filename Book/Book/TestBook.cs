using System;
class TestBook {
    static void Main() {
 
        //• Allow the user to input the number of books to add to the inventory.
        Console.Write("Enter the total number of books to add to the inventory: ");
        int total = Convert.ToInt32(Console.ReadLine());

        //• Create an array to store the specified number of Book objects.
        Book[] bk  = new Book[total];

        //• Prompt the user to input the details of each book (title, author, and price) and...
        for (int b = 0; b < total; b++) {

            Console.Write("Enter the book title: ");
            string title = Console.ReadLine();

            Console.Write("Enter the book author: ");
            string author = Console.ReadLine();

            Console.Write("Enter the price of a book: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();

            // store them in the array
            bk[b] = new Book(title, author, price);
        }

        //sorted alphabetically by title
        Array.Sort(bk, (a, b) => String.Compare(a.getTitle(), b.getTitle()) );

        //• Display the details of all books in the inventory.
        for (int i = 0; i < total; i++) {
            Console.WriteLine("Book number " + (i+1) + "\n" + bk[i].toString() + "\n");
        }

        Console.Read();
    }
}