using NUnit.Framework;
using System.IO;

using FinalProject;
using System.Collections.Generic;

// public class BogusInterFaceImplementation : IDataManagement
// {
//     public void LoadCourses(int ID)
//     {
//         throw new System.NotImplementedException();
//     }

//     public void SaveCourses(List<Course> courses, int ID)
//     {
//         throw new System.NotImplementedException();
//     }
// }

public class Tests
{

    CSVDataManagement data = new();

    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void TestIfLoadCoursesCreatesObject()
    {
        data.LoadCourses(1, "../../../1.csv");
        Assert.AreEqual("1234", CSVDataManagement.courseList[0].CRN);

    }

    [Test]
    public void TestIfMasterCoursesCanBeLoaded()
    {
        

    }



}