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

        var listofcourses = DataManagement.CourseFactory("C:/Users/thene/code/Final-Project-OOP-TheRealDeLorian/MasterCourseList.txt");
        Assert.IsInstanceOf(Course, listofcourses[0]);
          


    }

   
  
}