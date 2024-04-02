using System;

class TestEmployeesDriver {
    /*Implement the following functionalities:
    
    
   
    */

    static void Main()
    {
        //• Allow the user to input the number of employees.
        Console.WriteLine("Enter the total number of employess: ");
        int total = Convert.ToInt32(Console.ReadLine());

        //• Create an array to store the specified number of Employee objects.
        Employees[] emp = new Employees[total];

        //• Prompt the user to input the name and salary for each employee and...
        for (int e = 0; e < total; e++) {

            Console.Write("Enter the name of employee: ");
            string name = Console.ReadLine();
            Console.Write("Enter the salary: ");
            double salary = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine();
            //store them in the array

            emp[e] = new Employees(name, salary);
        }

        // • Calculate and display the average salary of all employees.
        double sum = 0;

        for (int i = 0; i < total; i++) {
            sum = sum + emp[i].getSalary();        
        }

        double average = sum / total;


        //• Display the details of employees whose salaries are above the average salary.
        for (int ii = 0; ii < total; ii++) {
            if (average < emp[ii].getSalary()) {
                Console.WriteLine("The employees whose salaries are above the average salary: \n" + emp[ii].toString());
            }
        }
        Console.Read();
    }
}