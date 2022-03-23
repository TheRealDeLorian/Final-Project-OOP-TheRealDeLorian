


class Program
{
    static void Main()
    {
        System.Console.WriteLine("Welcome. please enter your number");
        ReadInt(Console.ReadLine());

    }

    public int ReadInt(string input)
    {
       try
       {
           return int.Parse(input);
       }
       catch (Exception e)
       {
           System.Console.WriteLine(e.Message);
       }
        
    }
}
