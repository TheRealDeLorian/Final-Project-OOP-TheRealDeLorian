using System;
using System.Collections.Generic;
using System.Collections;
using FinalProject;


class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("Welcome. Are you ready to make a class schedule? Please enter your Student ID");
            int ID = Login.ReadInt();
            Student newStudent = new Student(ID);
            List<Course> courses = new List<Course>();

            if (File.Exists(Path.Combine("Courses", $"{ID}.csv")))
            {
                Console.WriteLine($"Welcome back, student number {ID}!\n1 - view your schedule\n2 - add to your schedule\n3 - delete your schedule and start over");  //I didn't have time to make a delete course method
                int input = Login.ReadInt(1, 3);
                switch (input)
                {
                    case 1:
                        CSVDataManagement data3 = new();
                        courses = data3.LoadCourses(ID);
                        foreach (Course course in courses)
                        {
                            CSVDataManagement.PrintCourse(course);
                        }
                        return;
                    case 2:
                        break;
                    case 3:
                        File.Delete(Path.Combine("Courses", $"{ID}.csv"));
                        break;
                }
            }

            Console.WriteLine("Let's get started! Press enter to show all courses, then choose which ones you want.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Loading...");

            CSVDataManagement data = new CSVDataManagement();
            Dictionary<int, Course> courseDict = new Dictionary<int, Course>();
            courses = data.LoadCourses(0);
            courseDict = data.courseDict;

            foreach (Course course in courses)
            {
                CSVDataManagement.PrintCourse(course);
            }

            Console.WriteLine("\nSelect courses by typing a CRN and pressing enter. When finished, input 0.");
            List<Course> studentSchedule = new();
            List<string> addedCourses = new();
            while (true)
            {
                int input = Login.ReadInt();
                if (input == 0)
                {
                    data.SaveCourses(newStudent.studentSchedule, ID);
                    Console.WriteLine("Schedule successfully saved. Press 1 to view.");
                    int input2 = Login.ReadInt(1, 1);
                    switch (input2)
                    {
                        case 1:
                            CSVDataManagement data2 = new CSVDataManagement();
                            courses = data2.LoadCourses(ID);
                            foreach (Course course in courses)
                            {
                                CSVDataManagement.PrintCourse(course);
                            }
                            return;

                    }

                }
                if (addedCourses.Contains(input.ToString()))
                {
                    Console.WriteLine($"Course {input} has already been added. Try another one.");
                }
                else
                {
                    try
                    {
                        newStudent.AddCourse(courseDict[input]);
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





}

