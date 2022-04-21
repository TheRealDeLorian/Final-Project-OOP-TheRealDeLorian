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

        while (true)
        {
            if (File.Exists(Path.Combine("Courses", $"{ID}.csv")))
            {
                Console.Clear();
                Console.WriteLine($"Welcome back, student number {ID}!\n1 - view your schedule\n2 - add to your schedule\n3 - delete your schedule and start over");  //I didn't have time to make a delete course method
                int input = Login.ReadInt(1, 3);
                switch (input)
                {
                    case 1:
                        CSVDataManagement.PrintSchedule(ID);
                        continue;
                    case 2:
                        ScheduleMaker();
                        break;
                    case 3:
                        File.Delete(Path.Combine("Courses", $"{ID}.csv"));
                        ScheduleMaker();
                        break;
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

        CSVDataManagement data = new CSVDataManagement();
        // Dictionary<int, Course> courseDict = new Dictionary<int, Course>();
        // courseDict = data.courseDict;
        CSVDataManagement.PrintSchedule(0);

        Console.WriteLine("\nSelect courses by typing a CRN and pressing enter. When finished, input 0.");
        List<Course> studentSchedule = new();
        List<string> addedCourses = new();
        while (true)
        {
            int input = Login.ReadInt();
            if (input == 0)
            {
                data.SaveCourses(newStudent.studentSchedule, ID);
                Console.WriteLine("Schedule successfully saved.");
                CSVDataManagement.PrintSchedule(ID);
                return;

                

            }
            if (addedCourses.Contains(input.ToString()))
            {
                Console.WriteLine($"Course {input} has already been added. Try another one.");
            }
            else
            {
                try
                {
                    newStudent.AddCourse(CSVDataManagement.courseDict[input]);
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

