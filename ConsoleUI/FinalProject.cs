using System;
using System.Collections.Generic;
using FinalProject;


class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome. Are you ready to make a class schedule? Please enter your Student ID");
        string id = Login.ReadInt();

        Console.WriteLine("Let's get started! Press enter to show all courses, then choose which ones you want.");
        Console.ReadKey(ConsoleKey.Enter);
        Console.WriteLine("Loading...");

        List<Course> courses = new List<Course>("0.csv");

        courses.LoadCourses();

        System.Console.WriteLine(courses.Description);




    }

    


    
}

