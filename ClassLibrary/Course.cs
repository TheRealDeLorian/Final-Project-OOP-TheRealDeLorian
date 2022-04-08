namespace FinalProject;

public class Course //all this needs to do is take a string, split it up, and convert it to what it needs to be. 
{
    public Course(string[] courseInfo) ///course info needs to be in this format: CRN\nCoursename\ntimeStart\ntimeEnd\ndescription\nweekday\nweekday2\n etc.
    {
         //will this work to put the \n? guess we'll find out
        if (courseInfo.Length == 6)
        {
            string CRN = courseInfo[0];
            string CourseName = courseInfo[1];
            string timeStart = courseInfo[2];
            string timeEnd = courseInfo[3];
            string description = courseInfo[4];
            string weekday = courseInfo[5];
        } //find a better way to overflow these if theres more than one weekday
        else if (courseInfo.Length == 7)
        {
            string CRN = courseInfo[0];
            string CourseName = courseInfo[1];
            string timeStart = courseInfo[2];
            string timeEnd = courseInfo[3];
            string description = courseInfo[4];
            string weekday = courseInfo[5];
            string weekday2 = courseInfo[6];
        }
    } //Use method overload or whatever to make it so that courses can have up to 5 possible weekdays

}



