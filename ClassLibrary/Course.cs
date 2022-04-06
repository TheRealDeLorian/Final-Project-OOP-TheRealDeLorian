namespace FinalProject;

public class Course //all this needs to do is take a string, convert it to the 
{
    public Course(string courseName, weekday courseDays, DateTime timeStart, DateTime timeEnd)
    {
        string CourseName = courseName; //I want this to be changeable but not by the UI
        weekday CourseDays = courseDays;
        DateTime TimeStart = timeStart;
        DateTime TimeEnd = timeEnd;
    } //Use method overflow or whatever to make it so that courses can have up to 5 possible weekdays
    public Course(string courseName) ///this is mostly for testing purposes.
    {
        string CourseName = courseName;
    }
    public Course() ///this is mostly for testing purposes.
    {

    }
}



