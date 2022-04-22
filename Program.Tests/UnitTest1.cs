using NUnit.Framework;
using System.IO;
using System;
using FinalProject;
using System.Collections.Generic;

public class BogusInterfaceImplementation : IDataManagement
{

    public string error;
    public void LoadCourses(int ID, string filePath)
    {
        if (!File.Exists(filePath))
        {
            error = "File not found.";
            Console.WriteLine(error);
        }  //test how it could respond if it doesnt find a file. simulate any behavior i want
    }

    public void SaveCourses(List<Course> courses, int ID)
    {
        throw new System.NotImplementedException();
    }
}

public class Tests
{

    CSVDataManagement data = new();

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestIfLoadCoursesCreatesObject() //adding a course, if it adds 1, make a schedule validator class that make sure they have certain courses. business rules
    {
        data.LoadCourses(1, "../../../1.csv");
        Assert.AreEqual("1234", CSVDataManagement.courseList[0].CRN);

    }

    [Test]
    public void TestWhatHappensIfFileNotFound()
    {
        BogusInterfaceImplementation BII = new();
        BII.LoadCourses(0, "bogusFile.css");

        Assert.AreEqual("File not found.", BII.error);
    }



}