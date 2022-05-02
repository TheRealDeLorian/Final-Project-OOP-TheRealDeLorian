//Dorian Cottle
//CS 1410
//5-1-2022
using System;
using System.Collections.Generic;
using System.Collections;
using FinalProject;

class Program
{
    static Student newStudent;
    static int ID;
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Welcome. Are you ready to make a class schedule? Please enter your Student ID");
        ID = Login.ReadInt();
        newStudent = new Student(ID);
        CSVDataManagement data = new();
        data.LoadCourses(0, Path.Combine("Courses", $"0.csv"));

        while (true)
        {
            if (File.Exists(Path.Combine("Courses", $"{ID}.csv")))
            {
                data.LoadCourses(ID, Path.Combine("Courses", $"{ID}.csv"));
                Console.Clear();
                Console.WriteLine($"Welcome back, student number {ID}!\n1 - view your schedule\n2 - add to your schedule\n3 - delete your schedule and start over\n0 - exit application");  //I didn't have time to make a delete course method
                int input = Login.ReadInt(0, 3);
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        CSVDataManagement.PrintSchedule(ID, data);
                        continue;
                    case 2:
                        Console.Clear();
                        ScheduleMaker(data);
                        break;
                    case 3:
                        Console.Clear();
                        File.Delete(Path.Combine("Courses", $"{ID}.csv"));
                        CSVDataManagement.courseDict.Clear();
                        CSVDataManagement.courseList.Clear();
                        ScheduleMaker(data);
                        break;
                    case 0:
                        return;
                }
            }
            else
            {
                ScheduleMaker(data);
            }
        }
    }

    public static void ScheduleMaker(CSVDataManagement data)
    {
        Console.Clear();
        Console.WriteLine("Let's get started! Press enter to show all courses, then choose which ones you want.");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Loading...");

        CSVDataManagement.PrintSchedule(0, data);

        Console.WriteLine("\nSelect courses by typing a CRN and pressing enter. When finished, input 0.");
        
        List<string> addedCourses = new();
        while (true)
        {
            int input = Login.ReadInt();
            if (input == 0)
            {
                data.SaveCourses(newStudent.studentSchedule, ID);
                Console.WriteLine("Schedule successfully saved.");
                return;
            }
            else if (CSVDataManagement.courseDict.ContainsKey(input))
            {
                Console.WriteLine($"Course {input} has already been added. Try another one or press 0 to save.");
            }
            else
            {
                try
                {
                    newStudent.AddCourse(CSVDataManagement.masterDict[input]); //takes a course already saved to masterdict and places it also in newStudent.AddCourse
                    CSVDataManagement.courseDict.Add(input, CSVDataManagement.masterDict[input]);
                    Console.WriteLine("Course added successfully. Enter another CRN or enter 0 to save.");
                }
                catch
                {
                    Console.WriteLine("Oops! Something went wrong. Please enter a valid CRN or 0 to save.");
                }
            }
        }
    }
}