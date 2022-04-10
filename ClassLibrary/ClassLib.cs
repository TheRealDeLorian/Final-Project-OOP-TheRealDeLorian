
namespace FinalProject;

public enum weekday
{
    Monday, Tuesday, Wednesday, Thursday, Friday
}

public static class DataManagement
{
    
    static System.Collections.Hashtable allCourses = new System.Collections.Hashtable(); //hashtable with all available courses
    public static List<string[]> courseLibrary = new List<string[]>();
    public static void CourseLibraryMaker(string fileName)
    {
        string fileString = File.ReadAllText(fileName);
        fileString.Replace("\r", "");
        List<string> splitString = fileString.Split('%').ToList<string>();
        for (int i = 0; i < splitString.Count; i++)
        {
            var courseInfo = splitString[i].Split('\r');
            courseLibrary.Add(courseInfo);
        }
        return;
    } 

    //method that takes each of those instances and puts into hashtable with CRN as the key
    //method that inputs a an instance of course (students choices) and saves to a file
    
    //method that reads student and teacher savedata files, and returns a hashtable of Courses* could be the same as above filereader and probably will be
    //various student schedule savedata files
            //teacher schedules (if time)
}


public class Login
{
    public int ReadInt(string input)
    {
        while(true)
        {
            try
            {
                return int.Parse(input);
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


// public class 