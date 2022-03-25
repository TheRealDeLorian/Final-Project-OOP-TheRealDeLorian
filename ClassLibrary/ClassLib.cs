namespace FinalProject;

using System.Collections.Generic;

public enum weekday
{
    Monday, Tuesday, Wednesday, Thursday, Friday
}




public class Course
{
    public Course(string courseName, weekday courseDays, DateTime timeStart, DateTime timeEnd, Professor professor)
    {
        string CourseName = courseName; //I want this to be changeable but not by the UI
        weekday CourseDays = courseDays;
        DateTime TimeStart = timeStart;
        DateTime TimeEnd = timeEnd;
        Professor Instructor = professor;
    } //Use method overflow or whatever to make it so that courses can have up to 5 possible weekdays


}

public class Person
{
    string phone;
    string email;

    List<Course> desiredCourses = new List<Course>(); //every time a course is dragged and dropped, it is added to this list. 
}
public class Professor : Person //make it make a list of type professors with all the professors by ID. 
{
    string office;
    string officeHours;

}

public class Student : Person
{

}

public class Calendar : IScheduleBlock
{

    public void EditTime(DateTime newTime)
    {

    }
    public void EditProfessor(Person newPerson)
    {

    }
    public void EditCredits(int newCredits)
    {

    }

    
}

public interface IScheduleBlock //it might be best to put these methods in some sort of admin-accessible class and not in calendar but I'll have to do it later
{
    public void EditTime(DateTime newTime);
    public void EditProfessor(Person newPerson);
    public void EditCredits(int newCredits);


}
