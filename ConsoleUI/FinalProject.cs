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

            Console.WriteLine("Let's get started! Press enter to show all courses, then choose which ones you want.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Loading...");

            CSVDataManagement data = new CSVDataManagement();
            Dictionary<int, Course> courseDict = new Dictionary<int, Course>();
            List<Course> courses = new List<Course>();
            courses = data.LoadCourses(0);
            courseDict = data.courseDict;

            foreach (Course course in courses)
            {
                CSVDataManagement.PrintCourse(course);
            }

            Console.WriteLine("\nSelect courses by typing a CRN and pressing enter. When finished, input 0.");
            List<Course> studentSchedule = new();
            while (true)
            {
                int input = Login.ReadInt();
                if (input == 0)
                {
                    data.SaveCourses(newStudent.studentSchedule, ID);
                    Console.WriteLine("Schedule successfully saved. Press 1 to view or press 0 to make another schedule.");
                    int input2 = Login.ReadInt();
                    switch (input2)
                    {
                        case 1:
                            List<Course> courses2 = new List<Course>();
                            courses2 = data.LoadCourses(ID);
                            foreach (Course course in courses2)
                            {
                                CSVDataManagement.PrintCourse(course);
                            }
                            return;
                        case 0:
                            break;
                    }
                    //save, return
                }
                try
                {
                    newStudent.AddCourse(courseDict[input]);
                    Console.WriteLine("Course added successfully. Enter another CRN or enter 0 to save and exit.");
                }
                catch
                {
                    Console.WriteLine("Oops! Something went wrong. Please enter a valid CRN or 0 to save and exit.");
                }
            }
        
        }

    }





}

