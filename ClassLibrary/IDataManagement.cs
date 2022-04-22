
namespace FinalProject;

using System;
using System.Collections;

public interface IDataManagement
{
    public void LoadCourses(int ID, string filePath);
    public void SaveCourses(List<Course> courses, int ID);


}

public class CSVDataManagement : IDataManagement
{
    public static Dictionary<int, Course> masterDict = new();
    public static List<Course> masterList = new();
    public static Dictionary<int, Course> courseDict = new Dictionary<int, Course>();
    public static List<Course> courseList = new();
    static bool masterListLoaded = false;
    public void LoadCourses(int ID, string filePath) //just makes the course objects and puts em in a list and a dictionary. That's all it does.
    {

        string CRN;
        string CourseName;
        string TimeStart;
        string TimeEnd;
        string Description;
        string[] Days;
        courseList.Clear();
        courseDict.Clear(); //or i could clear

        foreach (var line in File.ReadAllLines(filePath))
        {
            var courseInfoParts = line.Split(',');
            CRN = courseInfoParts[0];
            CourseName = courseInfoParts[1];
            TimeStart = courseInfoParts[2];
            TimeEnd = courseInfoParts[3];
            Description = courseInfoParts[4];
            Days = courseInfoParts[5].Split('|');

            var course = new Course(CRN)
            {
                CourseName = CourseName,
                TimeStart = TimeStart,
                TimeEnd = TimeEnd,
                Description = Description,
                Days = Days
            };
            if (ID == 0 && masterListLoaded == false) //loads the masterList
            {
                masterList.Add(course);
                // try
                // {
                    masterDict.Add(int.Parse(CRN), course);
                // }
                // catch
                // {

                // }
            }
            else //loads a courseList
            {
                courseList.Add(course);
                try
                {
                    courseDict.Add(int.Parse(CRN), course);
                }
                catch
                {
                    continue;
                }
            }
        }
        if (ID == 0)
        {
            masterListLoaded = true;
        }
        return;
    }

    public static void PrintCourse(Course course)
    {
        Console.WriteLine($"Course Name: {course.CourseName}");
        Console.WriteLine($"CRN: {course.CRN}");
        Console.Write("Days offered: ");
        foreach (string day in course.Days)
        {
            Console.Write($"{day} ");
        }
        Console.WriteLine($"from {course.TimeStart} to {course.TimeEnd}");
        Console.WriteLine($"Description: {course.Description}");
        Console.WriteLine("\n"); //to seperate the courses
    }

    public void SaveCourses(List<Course> courses, int ID)
    {
        StreamWriter writer = File.AppendText(Path.Combine("Courses", $"{ID}.csv"));
        foreach (Course course in courses)
        {
            writer.WriteLine($"{course.CRN},{course.CourseName},{course.TimeStart},{course.TimeEnd},{course.Description},{string.Join("|", course.Days)}");

        }
        writer.Close();
    }

    int duplicates = 0;
    public static void PrintSchedule(int ID, CSVDataManagement data)
    {
        // CSVDataManagement data = new CSVDataManagement();
        // data.LoadCourses(ID, Path.Combine("Courses", $"{ID}.csv"));
        if (ID == 0)
        {
            foreach (Course course in CSVDataManagement.masterList)
            {
                CSVDataManagement.PrintCourse(course);
            }
        }
        else
        {
            foreach (Course course in CSVDataManagement.courseList)
            {
                CSVDataManagement.PrintCourse(course);
            }
            Console.WriteLine("Press enter to continue.");
            Console.ReadKey();
        }
    }
}





















// try
// {
//     courseList.Add(course);
//     courseDict.Add(int.Parse(CRN), course);
// }
// catch
// {
//     if (courseDict.ContainsKey(int.Parse(CRN)))
//     {
//         duplicates++;
//         //Console.WriteLine($"Error. Multiple instances of course {CRN} detected."); //then use the course.remove method on that course to remove it when I finish it
//         continue;
//     }
// }