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
        Professor Allan = new Professor();
        Course testCourse = new Course("Programming Fundamentals", weekday.Monday, DateTime.Parse("08:30"), DateTime.Parse("09:20"), Allan);

        // Assert.AreEqual(testCourse);
        
    }
}