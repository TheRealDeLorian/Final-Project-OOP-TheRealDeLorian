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
                string ermsg = $"Whoops! Something went wrong. Make sure you only type numbers less than {int.MaxValue}.";
                Console.WriteLine(ermsg);
            }
        }
    }
}


