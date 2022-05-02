//this is the dev branch
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
            if (courseInfoParts.Length != 6)
            {
                Console.WriteLine("Error: File is unreadable. Be sure course information is in this format: crn,courseName,timeStart,timeEnd,description,day1|day2|day3");
                throw new Exception("File unreadable");
            }
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
                masterDict.Add(int.Parse(CRN), course);  
            }
            else //adds to the courseList
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

    public void SaveCourses(List<Course> courses, int ID)
    {
        File.WriteAllText(Path.Combine("Courses", $"{ID}.txt"), string.Empty);
        StreamWriter writer = File.AppendText(Path.Combine("Courses", $"{ID}.txt"));
        foreach (Course course in courses)
        {
            writer.WriteLine($"{course.CRN},{course.CourseName},{course.TimeStart},{course.TimeEnd},{course.Description},{string.Join("|", course.Days)}");

        }
        writer.Close();
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

    int duplicates = 0;
    public static void PrintSchedule(int ID, CSVDataManagement data)
    {
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

