namespace FinalProject;

public class Course
{
    static List<Course> AllCourses = new List<Course>();
    public Course(string crn, string courseName, weekday courseDays, DateTime timeStart, DateTime timeEnd, Professor professor)
    {
        string CRN = crn; //CRN = Course Regisration Number
        string CourseName = courseName; //I want this to be changeable but not by the UI
        weekday CourseDays = courseDays;
        DateTime TimeStart = timeStart;
        DateTime TimeEnd = timeEnd;
        Professor Instructor = professor;

    } //Use method overflow or whatever to make it so that courses can have up to 5 possible weekdays
    public Course(string courseName) ///this is mostly for testing purposes.
    {
        string CourseName = courseName;
    }
    public Course() ///this is mostly for testing purposes.
    {

    }

    public Tuple<string[], string[]> MasterCourseListReader() //return list of literally every single course
    {
        string text = System.IO.File.ReadAllText("C:/users/thene/code/Final-Project-OOP-TheRealDeLorian/MasterCourseList.txt");
        string[] splitCourseList = text.Split('%');
        string[] splitCourseItems = GetStringArray(splitCourseList);





        Tuple<string[], string[]>(splitCourseList, splitcourseItems);
        return

        
        Dictionary<List<string>, string> courseInfo = new Dictionary<List<string>, string>();

        // courseInfo.Add()


    }

    public string[] GetStringArray(string[] x)
    {
        for (int j = 0; j < y.Length; j++)
        {
            for (int i = 0; i < x.Length; i++)
            {
                x[i] = y.Split(";");

            }
        }
    }



}


class ReadFromFile
{

}
