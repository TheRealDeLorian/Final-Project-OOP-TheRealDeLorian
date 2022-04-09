namespace FinalProject;

public class Course //all this needs to do is take a string, split it up, and convert it to what it needs to be. 
{
    public Course(string[] courseInfo) ///course info needs to be in this format: CRN\nCoursename\ntimeStart\ntimeEnd\ndescription\nweekday\nweekday2\n etc.
    {
        if (courseInfo.Length < 6)
        {
            Console.WriteLine("Fewer than 6 lines of information. Possible errors in the future.");
        }
        string CRN = courseInfo[0];
        string CourseName = courseInfo[1];
        string timeStart = courseInfo[2];
        string timeEnd = courseInfo[3];
        string description = courseInfo[4];
        string weekday = courseInfo[5];
        if (courseInfo.Length >= 7)
        {
            string weekday2 = courseInfo[6];
        }
        else if (courseInfo.Length >= 8)
        {
            string weekday3 = courseInfo[7];
        }
        else if (courseInfo.Length >= 9)
        {
            string weekday4 = courseInfo[8];
        }
        else if (courseInfo.Length >= 10)
        {
            string weekday5 = courseInfo[9];
        }//find a better way to overflow these if theres more than one weekday
    }

}



