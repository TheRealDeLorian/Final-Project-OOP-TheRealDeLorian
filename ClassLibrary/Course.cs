namespace FinalProject;

public class Course
{
    static List<Course> AllCourses = new List<Course>();
    public Course(string crn, string courseName, weekday courseDays, DateTime timeStart, DateTime timeEnd, int credits, Professor professor)
    {
        string CRN = crn; //CRN = Course Regisration Number
        string CourseName = courseName; //I want this to be changeable but not by the UI
        weekday CourseDays = courseDays;
        DateTime TimeStart = timeStart;
        DateTime TimeEnd = timeEnd;
        int Credits = credits;
        Professor Instructor = professor;

    } //Use method overflow or whatever to make it so that courses can have up to 5 possible weekdays
    public Course(string courseName) ///this is mostly for testing purposes.
    {
        string CourseName = courseName;
    }
    public Course() ///this is mostly for testing purposes.
    {

    }

    public Tuple<string, string, weekday, DateTime, DateTime, int, string> MasterCourseListReader() //return list of literally every single course
    {
        string text = System.IO.File.ReadAllText("C:/users/thene/code/Final-Project-OOP-TheRealDeLorian/MasterCourseList.txt");
        string[] splitCourseList = text.Split('%');


        string[] splitCourseItems = new string[7]; //basically I need to text.Split(';') with each item in splitcourseitems.

        for (int i = 0; i < splitCourseList.Length; i++)
        {
            splitCourseItems = splitCourseList[i].Split(';');
        }

        string CRN = splitCourseItems[0];
        string CourseName = splitCourseItems[1];
        weekday Weekday = (weekday)Enum.Parse(typeof(weekday), splitCourseItems[2]);
        DateTime TimeStart = DateTime.Parse(splitCourseItems[3]);
        DateTime TimeEnd = DateTime.Parse(splitCourseItems[4]);
        int Credits = int.Parse(splitCourseItems[5]);
        string Instructor = splitCourseItems[6];

        Tuple<string, string, weekday, DateTime, DateTime, int, string> courseInfo = new Tuple<string, string, weekday, DateTime, DateTime, int, string>(CRN, CourseName, Weekday, TimeStart, TimeEnd, Credits, Instructor);
        return courseInfo;

        // using (var reader = new StringReader(splitCourseList[i]))
        //     {
        //         for (string line = reader.ReadLine(); line != null; line = reader.ReadLine())
        //         {
                    
        //         }
        //     }



        // Tuple<string[], string[]>(splitCourseList, splitcourseItems);
        // return


        // Dictionary<List<string>, string> courseInfo = new Dictionary<List<string>, string>();

        // courseInfo.Add()


    }

    // public string[] GetStringArray(string[] x)
    // {
    //     for (int j = 0; j < y.Length; j++)
    //     {
    //         for (int i = 0; i < x.Length; i++)
    //         {
    //             x[i] = y.Split(";");

    //         }
    //     }
    // }



}


class ReadFromFile
{

}
