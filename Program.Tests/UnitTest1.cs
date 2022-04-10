using NUnit.Framework;
using System;

namespace FinalProject;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void Test1()
    {

        DataManagement.CourseLibraryMaker("C:/Users/thene/code/Final-Project-OOP-TheRealDeLorian/MasterCourseList.txt");
        Assert.AreEqual("1593", DataManagement.courseLibrary[0][0]);
          


    }

    [Test]
    public void Test2() //just to see if course classes can be made
    {
        string[] info = {"1854", "intro to web dev", "11:00", "12:15", "learn web development", "Monday"};
        Course testCourse = new Course(info);
        Assert.AreEqual("1854", testCourse.CRN, "Should equal 1854");
        Assert.AreEqual("Monday", testCourse.weekday);
    }

   
  
}