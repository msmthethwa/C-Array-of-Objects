using System;
class Students {
    /*

    Develop a C# program for a student grading system. Create a class Student with properties Name 
    (string) and Grades (array of integers). Implement the following functionalities:
    */

    private String Name;
    private int[] Grades;

    public Students(String name, int[] grades)
    {
        Name = name;
        Grades = grades;
    }

    public String getName() { 
        return Name;
    }
    public int[] getGrades()
    {
        return Grades;
    }

    public void setName(String name)
    {
        Name = name;
    }
    public void setGrades(int[] grades) { 
        Grades = grades;
    }

    public int calculateAverageGrades() {
        int sum = 0;

        for (int i = 0; i < Grades.Length; i++) { 
            sum = sum + Grades[i];
        }

        int average = sum / Grades.Length;
        return average;
    }
}