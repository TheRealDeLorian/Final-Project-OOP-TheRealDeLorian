namespace FinalProject;

public class Course
{
    List<Course> AllCourses = new List<Course>();
    public Course(string crn, string courseName, weekday courseDays, DateTime timeStart, DateTime timeEnd, Professor professor)
    {
        string CRN = crn; //CRN = Course Regisration Number
        string CourseName = courseName; //I want this to be changeable but not by the UI
        weekday CourseDays = courseDays;
        DateTime TimeStart = timeStart;
        DateTime TimeEnd = timeEnd;
        Professor Instructor = professor;
    } //Use method overflow or whatever to make it so that courses can have up to 5 possible weekdays



    public Course(string courseName) //this is mostly for testing purposes.
    {
        string CourseName = courseName;
    }

    // List<Course> MasterCourseListReader()
    // {
    //     //filestream etc etc
    //     //return list of literally every single course
    // }

}
