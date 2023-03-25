namespace FinalProject;

using System.Collections.Generic;

public abstract class Person
{
    string phone;
    string email;

    List<Course> courseSchedule = new List<Course>(); //every time a course is dragged and dropped, it is added to this list. 
}

public class Student : Person
{
    public Student()
    {

    }
    static int studentsRegistered = 0;
    static int coursesRegistered = 0;
    public static string studentID;
    public static List<Course> studentSchedule = new List<Course>();

    public static void AddCourse(Course courseToBeAdded)//make overflows with course ID numbers and other abbreviations
    {
        if(studentSchedule.Count == 0)
        {
            studentsRegistered++;
        }
        
        studentSchedule.Add(courseToBeAdded);
        coursesRegistered++;
        return;
    }

    
    
}

public class Professor : Person //make it make a list of type professors with all the professors by ID. 
{
    string office;
    string officeHours;
    List<Course> professorSchedule = new List<Course>();

    public void AddCourse(Course courseToBeAdded)
    {
        professorSchedule.Add(courseToBeAdded);
    }
}

