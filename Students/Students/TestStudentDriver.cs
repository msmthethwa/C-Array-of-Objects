using System;
class TestStudentDriver {
    static void Main() {


        //• Allow the user to input the number of students.
        Console.Write("Enter the total number of students: ");
        int total = Convert.ToInt32(Console.ReadLine());

        //• Create an array to store the specified number of Student objects.
        Students[] st = new Students[total];

        //• For each student, prompt the user to input the name and grades (an array of integers) and... 
        

        for (int i = 0; i < total; i++) { 
            Console.Write("Enter the studnet name: ");
            string name = Console.ReadLine();

            
            int[] grd = new int[4];

            for (int x = 0; x < 4; x++) {
                int score = 0;
                Console.Write("Enter test " + (x+1) + " score: ");
                score = Convert.ToInt32(Console.ReadLine());

                grd[x] = score;
            }

            //  store them in the corresponding Student object.
            st[i] = new Students(name, grd);

            Console.WriteLine();
        }

        //• display the average grade for each student.
        Console.WriteLine("\tThe average grade for each student.");
        for (int i = 0; i < total; i++) {
            Console.WriteLine("The average grade for " + st[i].getName() + ": " + st[i].calculateAverageGrades() + "\n");

        }

        //• Calculate and display the overall class average grade.

        int TotalAvgGrd = 0;

        for (int i = 0; i < total; i++) {
            TotalAvgGrd = TotalAvgGrd + st[i].calculateAverageGrades();
        }

        int ClassAvgGrd = TotalAvgGrd / total;

        Console.WriteLine("The overall class average grade: " + ClassAvgGrd);

        Console.Read();
    }
}