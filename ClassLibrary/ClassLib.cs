﻿
namespace FinalProject;

public class StudentScheduleDataManagement : IDataManagement
{
    public IEnumerable<Course> LoadCourses()
    {
        List<Course> courses = new List<Course>();
        if (File.Exists("MasterCourseList.txt"))
        {
            courses = Course.Load("MasterCourseList.txt");
        }
        return courses;
    }

    public void SaveCourses(IEnumerable<Course> courses)
    {
        throw new NotImplementedException();
    }
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


