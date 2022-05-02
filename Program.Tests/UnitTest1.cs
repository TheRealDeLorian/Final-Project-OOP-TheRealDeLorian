using NUnit.Framework;
using System.IO;
using System;
using FinalProject;
using System.Collections.Generic;

public class BogusInterfaceImplementation : IDataManagement
{
    public Course newCourse;
    public string error;
    public List<Course> testCourseList;

    public void LoadCourses(int ID, string filePath)
    {
        if (File.Exists(filePath) == false)
        {
            error = "File not found. Generating file.";
            Console.WriteLine(error);
            File.Create(filePath);
        }  //test how it could respond if it doesnt find a file. simulate any behavior i want

        foreach (string line in File.ReadAllLines(filePath))
        {
            testCourseList.Add(new Course(line));
        }
    }

    public void SaveCourses(List<Course> courses, int ID)
    {
        foreach (Course course in courses)
        {
            File.AppendText(Path.Combine("TestCourses", $"{ID}.txt"));
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
    public void TestIfReadIntWillReturnErrorMessage()
    {
        Login.ReadInt();
    }

    [Test]
    public void TestIfLoadCoursesCreatesObject()
    {
        BogusInterfaceImplementation BII = new();
        int ID = 6;
        BII.LoadCourses(ID, $"{ID}.txt");

        Assert.IsInstanceOf<Course>(BII.newCourse);
    }

    [Test]
    public void TestIfLoadCoursesCreatesObjectWithAccessibleData() //adding a course, if it adds 1, make a schedule validator class that make sure they have certain courses. business rules
    {
        BogusInterfaceImplementation BII = new();
        int ID = 6;
        BII.LoadCourses(ID, $"{ID}.txt");

        Assert.AreEqual("6789", BII.newCourse.CRN);

    }

    [Test]
    public void TestWhatHappensIfFileNotFound()
    {
        BogusInterfaceImplementation BII = new();
        BII.LoadCourses(0, "bogusFile.css");

        Assert.AreEqual("File not found. Generating file.", BII.error);
    }
}