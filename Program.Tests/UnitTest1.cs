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
        Student Dorian = new Student();
        Course ProgFund = new Course("Programming Fundamentals"); //when the program runs I want it to have a database of courses already
        Dorian.AddCourse(ProgFund);

        Assert.AreEqual(ProgFund, Dorian.studentSchedule[0]); //Passed!

    }

    [Test]
    public void Test2()
    {
        Course TestCourse = new Course();
        string[] test = TestCourse.MasterCourseListReader();

        Assert.AreEqual("1593 ;\r\nA Cappella Choir ;\r\nMWF ;\r\n1:30 PM ;\r\n2:20 PM ;\r\n1 ;\r\nMichael Huff ;\r\n\r\n", test[0]);

    }
}