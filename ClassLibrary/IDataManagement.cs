
namespace FinalProject;
using System.Collections;

public interface IDataManagement
{
    public Hashtable LoadCourses(int ID);
    public void SaveCourses(Hashtable courses, int ID);

   
}

public class CSVDataManagement : IDataManagement
{
    public Hashtable LoadCourses(int ID)
    {
        var courses = new Hashtable();
        string CRN;
        string CourseName;
        string TimeStart;
        string TimeEnd;
        string Description;
        string[] Days;
        string filePath = Path.Combine("Courses", $"{ID}.csv");

        foreach (var line in File.ReadAllLines(filePath))
        {
            var courseInfoParts = line.Split(',');
            CRN = courseInfoParts[0];
            CourseName = courseInfoParts[1];
            TimeStart = courseInfoParts[2];
            TimeEnd = courseInfoParts[3];
            Description = courseInfoParts[4];
            Days = courseInfoParts[5].Split('|');

            var course = new Course(CRN) {
                CourseName = CourseName,
                TimeStart = TimeStart,
                TimeEnd = TimeEnd,
                Description = Description,
                Days = Days
            };
            courses.Add(CRN, course);
        }
        return courses;
    }

public void PrintCourse(Course course)
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

    public void SaveCourses(Hashtable courses, int ID)
    {
        StreamWriter writer = new StreamWriter(Path.Combine("Courses", $"{ID}.csv"));
        writer.WriteLine(courses);
        writer.Close();
    }
}