namespace FinalProject;
using System.Collections;

public class StudentScheduleDataManagement : IDataManagement
{
    public Hashtable LoadCourses(int ID)
    {
        Hashtable courses = new Hashtable();
        if (File.Exists("MasterCourseList.txt"))
        {
            // courses = Course.LoadCourses("MasterCourseList.txt");
        }
        return courses;
    }

    public void SaveCourses(Hashtable courses, int ID)
    {
        throw new NotImplementedException();
    }
}





public class Login
{
    public static int ReadInt()
    {
        while(true)
        {
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch
            {
                string ermsg = "Whoops! Something went wrong. Make sure you only type numbers.";
                Console.WriteLine(ermsg);
            }
        }
    }
}



public class Calendar : IScheduleBlock
{

    public void EditTime(DateTime newTime)
    {

    }
    public void EditProfessor(Person newPerson)
    {

    }
    public void EditCredits(int newCredits)
    {

    }

    
}

public interface IScheduleBlock //it might be best to put these methods in some sort of admin-accessible class and not in calendar but I'll have to do it later
{
    public void EditTime(DateTime newTime);
    public void EditProfessor(Person newPerson);
    public void EditCredits(int newCredits);




}


