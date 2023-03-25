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
    static string ID;
    static void Main()
    {
        Console.Clear();
        Console.WriteLine("Welcome. Are you ready to make a class schedule? Please enter your Student ID");
        ID = LoginClass.ReadInt().ToString();
        newStudent = new Student();
        DataMan.LoadCourses("0", Path.Combine(Directory.GetCurrentDirectory(), $"Courses/0.txt"));

        while (true)
        {
            if (File.Exists(Path.Combine("Courses", $"{ID}.txt")))
            {
                DataMan.LoadCourses(ID, Path.Combine("Courses", $"{ID}.txt"));
                Console.Clear();
                Console.WriteLine($"Welcome back, student number {ID}!\n1 - view your schedule\n2 - add to your schedule\n3 - delete your schedule and start over\n0 - exit application");  //I didn't have time to make a delete course method
                int input = LoginClass.ReadInt(0, 3);
                switch (input)
                {
                    case 1:
                        Console.Clear();
                        PrintSchedule(ID);
                        continue;
                    case 2:
                        Console.Clear();
                        ScheduleMaker();
                        break;
                    case 3:
                        Console.Clear();
                        File.WriteAllText(Path.Combine("Courses", $"{ID}.txt"), string.Empty);
                        File.Delete(Path.Combine("Courses", $"{ID}.txt"));
                        DataMan.courseDict.Clear();
                        DataMan.courseList.Clear();
                        ScheduleMaker();
                        break;
                    case 0:
                        return;
                }
            }
            else
            {
                ScheduleMaker();
            }
        }
    }

    public static void ScheduleMaker()
    {
        Console.Clear();
        Console.WriteLine("Let's get started! Press enter to show all courses, then choose which ones you want.");
        Console.ReadKey();
        Console.Clear();
        Console.WriteLine("Loading...");

        PrintSchedule("0");

        Console.WriteLine("\nSelect courses by typing a CRN and pressing enter. When finished, input 0.");

        List<string> addedCourses = new();
        bool changes = false;
        while (true)
        {
            int input = LoginClass.ReadInt();
            if (input == 0)
            {
                if (changes)
                {
                    DataMan.SaveCourses(Student.studentSchedule, ID);
                }
                else if (!changes && DataMan.courseList.Count == 0)
                {
                    Console.Clear();
                    Console.WriteLine("Nothing saved. Courselist is currently empty. Press enter to continue and add courses.");
                    Console.ReadKey();
                    break;
                }
                Console.WriteLine("Schedule successfully saved.");
                return;
            }
            else if (DataMan.courseDict.ContainsKey(input))
            {
                Console.WriteLine($"Course {input} has already been added. Try another one or press 0 to save.");
            }
            else
            {
                try
                {
                    Student.AddCourse(DataMan.masterDict[input]); //takes a course already saved to masterdict and places it also in newStudent.AddCourse
                    DataMan.courseDict.Add(input, DataMan.masterDict[input]);
                    Console.WriteLine("Course added successfully. Enter another CRN or enter 0 to save.");
                    changes = true;
                }
                catch
                {
                    Console.WriteLine("Oops! Something went wrong. Please enter a valid CRN or 0 to save.");
                }
            }
        }
    }

    public static void PrintSchedule(string ID)
    {
        if (ID == "0")
        {
            foreach (Course course in DataMan.masterList)
            {
                PrintCourse(course);
            }
        }
        else
        {
            foreach (Course course in DataMan.courseList)
            {
                PrintCourse(course);
            }
            Console.WriteLine("Press enter to continue.");
            Console.ReadKey();
        }
    }

    public static void PrintCourse(Course course)
    {
        Console.WriteLine($"Course Name: {course.CourseName}");
        Console.WriteLine($"CRN: {course.CRN}");
        Console.Write("Days offered: ");
        foreach (string day in course.Days)
        {
            Console.Write($"{day} ");
        }
        Console.WriteLine($"from {course.TimeStart} to {course.TimeEnd}");
        Console.WriteLine($"Description: {course.Description}");
        Console.WriteLine("\n"); //to seperate the courses
    }
}