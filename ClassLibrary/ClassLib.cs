
namespace FinalProject;

public enum weekday
{
    Monday, Tuesday, Wednesday, Thursday, Friday
}

public static class DataManagement
{
    
    static System.Collections.Hashtable allCourses = new System.Collections.Hashtable(); //hashtable with all available courses
    //method that reads a file 
    static string Read(string fileName) => File.ReadAllText(fileName); //ADD WHAT IF FILE NOT FOUND
    //method that takes those splits and turns each into an instance of course
    static List<Course> courseList = new();
    public static List<Course> CourseFactory(string fileName)
    {
        string fileString = File.ReadAllText(fileName);
        List<string> splitString = fileString.Split('%').ToList<string>();
        //so now weve got a list of strings, each string has each piece we need to make one instance of Course class. We need to split each member of splitstring into another array of strings, then feed each of those pieces into a class. 
        for (int i = 0; i < splitString.Count; i++)
        {
            var courseInfo = splitString[i].Split('\n');
            var name = $"Course {i}";
            courseList.Add(new Course(courseInfo));
            // Course newCourse = new Course(courseInfo);
        }
        return courseList;
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