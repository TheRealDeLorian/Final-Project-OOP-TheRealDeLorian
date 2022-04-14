using NUnit.Framework;
using System.IO;

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
        Assert.AreEqual(true, File.Exists("C:/Users/thene/code/Final-Project-OOP-TheRealDeLorian/ClassLibrary/MasterCourseList.txt"));
    }

    [Test]
    public void Test2() //just to see if course classes can be made
    {
        
    }

   
  
}