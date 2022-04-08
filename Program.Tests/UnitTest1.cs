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
       var idk = DataManagement.CourseFactory("@C:/Users/thene/code/Final-Project-OOP-TheRealDeLorian/MasterCourseList.txt");

       Console.WriteLine(idk[1]);

    }

   
  
}