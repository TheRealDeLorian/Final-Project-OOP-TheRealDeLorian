namespace FinalProject;
using System.Collections;


public class Login
{
    public static int ReadInt(int min = int.MinValue, int max = int.MaxValue)
    {
        while(true)
        {
            try
            {
                int input = int.Parse(Console.ReadLine());
                if (input >= min && input <= max)
                {
                    return input;
                }
                Console.WriteLine($"Please enter an integer between {min} and {max}");
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


