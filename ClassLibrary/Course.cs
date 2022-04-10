namespace FinalProject;

public class Course //all this needs to do is take a string, split it up, and convert it to what it needs to be. 
{
    public string CRN;
    public string CourseName;
    public string timeStart;
    public string timeEnd;
    public string description;
    public string weekday;
    public string weekday2;
    public string weekday3;
    public string weekday4;
    public string weekday5;
    public Course(string[] courseInfo) ///course info needs to be in this format: CRN\nCoursename\ntimeStart\ntimeEnd\ndescription\nweekday\nweekday2\n etc.
    {
        if (courseInfo.Length < 6)
        {
            Console.WriteLine("Fewer than 6 lines of information. Possible errors in the future.");
        }
        CRN = courseInfo[0];
        CourseName = courseInfo[1];
        timeStart = courseInfo[2];
        timeEnd = courseInfo[3];
        description = courseInfo[4];
        weekday = courseInfo[5];
        // if (courseInfo.Length >= 7)
        // {
            // weekday2 = courseInfo[6];
        // }
        // else if (courseInfo.Length >= 8)
        // {
        //     weekday2 = courseInfo[6];
            // weekday3 = courseInfo[7];
        // }
        // else if (courseInfo.Length >= 9)
        // {
        //     weekday2 = courseInfo[6];
        //     weekday3 = courseInfo[7];
            // weekday4 = courseInfo[8];
        // }
        // else if (courseInfo.Length >= 10)
        // {
        //     weekday2 = courseInfo[6];
        //     weekday3 = courseInfo[7];
        //     weekday4 = courseInfo[8];
            // weekday5 = courseInfo[9];
        // }//find a better way to overflow these if theres more than one weekday
    }

}



