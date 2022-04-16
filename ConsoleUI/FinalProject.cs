using System;
using System.Collections.Generic;
using FinalProject;


class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome. Are you ready to make a class schedule? Please enter your Student ID");
        int ID = Login.ReadInt();

        Console.WriteLine("Let's get started! Press enter to show all courses, then choose which ones you want.");
        Console.ReadKey();
        Console.WriteLine("Loading...");

        List<Course> courses = new List<Course>();

        CSVDataManagement data = new CSVDataManagement();
        data.LoadCourses(0);

        System.Console.WriteLine(data[0].Description);




    }

    


    
}

