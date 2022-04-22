using NUnit.Framework;
using System.IO;
using System;
using FinalProject;
using System.Collections.Generic;

public class BogusInterfaceImplementation : IDataManagement
{
    public static List<Course> testCourseList;
    public string error;
    public void LoadCourses(int ID, string filePath)
    {
        if (!File.Exists(filePath))
        {
            error = "File not found. Generating file.";
            Console.WriteLine(error);
            File.Create(filePath);
        }  //test how it could respond if it doesnt find a file. simulate any behavior i want
        else
        {
            foreach (string line in File.ReadAllLines(filePath))
            {
                testCourseList.Add(new Course(line));
            }
        }
    }

    public void SaveCourses(List<Course> courses, int ID)
    {
        foreach (Course course in courses)
        {
            File.AppendText(Path.Combine("TestCourses", $"{ID}.csv"));
        }
    }
}

public class Tests
{

    [SetUp]
    public void Setup()
    {
    }


    [Test]
    public void TestIfLoadCoursesCreatesObject() //adding a course, if it adds 1, make a schedule validator class that make sure they have certain courses. business rules
    {
        BogusInterfaceImplementation BII = new();
        int ID = 6;
        BII.LoadCourses(ID, $"{ID}.csv");

        Assert.IsInstanceOf<Course>(BogusInterfaceImplementation.testCourseList[0]);

    }

    [Test]
    public void TestIfLoadCoursesCreatesObjectWithAccessibleData() //adding a course, if it adds 1, make a schedule validator class that make sure they have certain courses. business rules
    {
        BogusInterfaceImplementation BII = new();
        int ID = 6;
        BII.LoadCourses(ID, $"{ID}.csv");

        Assert.AreEqual("1234", BogusInterfaceImplementation.testCourseList[0].CRN);

    }

    [Test]
    public void TestWhatHappensIfFileNotFound()
    {
        BogusInterfaceImplementation BII = new();
        BII.LoadCourses(0, "bogusFile.css");

        Assert.AreEqual("File not found. Generating file.", BII.error);
    }
}