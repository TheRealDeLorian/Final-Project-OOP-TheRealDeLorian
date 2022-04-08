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
        Course ProgFund = new Course(); //when the program runs I want it to have a database of courses already
        Dorian.AddCourse(ProgFund);

        Assert.AreEqual(ProgFund, Dorian.studentSchedule[0]); //Passed!

    }

   
  
}