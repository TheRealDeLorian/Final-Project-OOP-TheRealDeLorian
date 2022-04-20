
namespace FinalProject;
using System.Collections;

public interface IDataManagement
{
    public List<Course> LoadCourses(int ID);
    public void SaveCourses(List<Course> courses, int ID);


}

public class CSVDataManagement : IDataManagement
{
    public Dictionary<int, Course> courseDict = new Dictionary<int, Course>();
    public List<Course> LoadCourses(int ID) //
    {
        var courseList = new List<Course>();
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

            var course = new Course(CRN)
            {
                CourseName = CourseName,
                TimeStart = TimeStart,
                TimeEnd = TimeEnd,
                Description = Description,
                Days = Days
            };
            try
            {
                courseDict.Add(int.Parse(CRN), course);
                courseList.Add(course);
            }
            catch 
            {
                int errors = 0;
                if (courseDict.ContainsKey(int.Parse(CRN)))
                {
                    errors++;
                    Console.WriteLine($"Error. Multiple instances of course {CRN} detected."); //then use the course.remove method on that course to remove it when I finish it
                    continue;
                }
            }
        }
        return courseList;
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
}