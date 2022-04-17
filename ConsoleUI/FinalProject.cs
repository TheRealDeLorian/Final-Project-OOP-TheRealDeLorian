using System;
using System.Collections.Generic;
using FinalProject;


class Program
{
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Welcome. Are you ready to make a class schedule? Please enter your Student ID");
        int ID = Login.ReadInt();
        Student newStudent = new Student(ID);

        Console.WriteLine("Let's get started! Press enter to show all courses, then choose which ones you want.");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Loading...");

        CSVDataManagement data = new CSVDataManagement();
        List<Course> courses = new List<Course>();
        courses = data.LoadCourses(0); 

        foreach (Course course in courses)
        {
            data.PrintCourse(course);
        }

        Console.WriteLine("\nSelect courses by typing a CRN and pressing enter. When finished, press enter twice.");
        int input = Login.ReadInt();
        while (true)
        {
            if (input == 0)
            {
                //save, return
            }
            newStudent.MakeSchedule(input);
        
        }




    }

    


    
}

