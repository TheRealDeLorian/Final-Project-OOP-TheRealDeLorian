namespace FinalProject;

public class Course //all this needs to do is take a string, split it up, and convert it to what it needs to be. 
{
    public Course(string courseInfo) ///course info needs to be in this format: CRN\nCoursename\ntimeStart\ntimeEnd\ndescription\nweekday\nweekday2\n etc.
    {
        string[] infoArray = courseInfo.Split('\n'); //will this work to put the \n? guess we'll find out
        if (infoArray.Length == 6)
        {
            string CRN = infoArray[0];
            string CourseName = infoArray[1];
            string timeStart = infoArray[2];
            string timeEnd = infoArray[3];
            string description = infoArray[4];
            string weekday = infoArray[5];
        } //find a better way to overflow these if theres more than one weekday
    } //Use method overload or whatever to make it so that courses can have up to 5 possible weekdays

}



