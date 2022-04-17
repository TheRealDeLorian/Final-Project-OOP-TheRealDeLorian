namespace FinalProject;

using System.Collections.Generic;

public abstract class Person
{
    string phone;
    string email;

    List<Course> courseSchedule = new List<Course>(); //every time a course is dragged and dropped, it is added to this list. 

    public void AddCourse()
    {
        
    }
    
}

public class Student : Person
{

    public Student(int ID)
    {
        var studentID = ID;
    }
    static int studentsRegistered = 0;

    public int studentID;
    public List<Course> studentSchedule = new List<Course>();

    public void AddCourse(Course courseToBeAdded)//make overflows with course ID numbers and other abbreviations
    {
        if(studentSchedule.Count == 0)
        {
            studentsRegistered++;
        }

        studentSchedule.Add(courseToBeAdded);
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

