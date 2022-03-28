namespace FinalProject;

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

    public Course(string courseName)
    {
        string CourseName = courseName;
    }

}
