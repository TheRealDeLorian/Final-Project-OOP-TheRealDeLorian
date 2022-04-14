namespace FinalProject;

public class Course //all this needs to do is take a string, split it up, and convert it to what it needs to be. 
{
    public Course(string crn) ///course info needs to be in this format: CRN\nCoursename\ntimeStart\ntimeEnd\ndescription\nweekday\nweekday2\n etc.
    {
        CRN = crn;

    }

    public string CRN { get; }
    public string CourseName { get; set; }
    public string TimeStart { get; set; }
    public string TimeEnd { get; set; }
    public string Description { get; set; }
    public string[] Days { get; set; }

    public virtual void SaveCourseToFile(StreamWriter writer)
    {
        writer.WriteLine("CRN:" + this.CRN);
        writer.WriteLine("CourseName:" + this.CourseName);
        writer.WriteLine("TimeStart:" + this.TimeStart);
        writer.WriteLine("TimeEnd:" + this.TimeEnd);
        writer.WriteLine("Description:" + this.Description);
        writer.WriteLine("Days:" + this.Days);
    }

    

    //make the save method

    //make some non abstract classes for courses with more than one day


}











