using System;

/*Design a C# program that manages a collection of Employee objects. 
 * Each Employee object should have properties for Name (string) and Salary (double).
 
Implement the following functionalities:
• Allow the user to input the number of employees.
• Create an array to store the specified number of Employee objects.
• Prompt the user to input the name and salary for each employee and store them in the array.
• Calculate and display the average salary of all employees.
• Display the details of employees whose salaries are above the average salary.
*/

class Employees {
    private String Name;
    private double Salary;

    public Employees()
    {
        Name = null;
        Salary = 0;
    }
    public Employees(String name, double salary)
    {
        Name = name;
        Salary = salary;
    }

    public String getName() { 
        return Name;
    }
    public double getSalary()
    {
        return Salary;
    }

    public void setName(String name)
    {
        Name = name;
    }
    public void setSalary(double salary) {
        Salary = salary;
    }

    public String toString() {
        String str;
        str = "Name: " + Name + "\nSalary: " + Salary;
        return str;
    }
}