//this is the dev branch
namespace FinalProject;
using System;
using System.Collections;

public static class DataMan
{
    public static Dictionary<int, Course> masterDict = new();
    public static List<Course> masterList = new();
    public static Dictionary<int, Course> courseDict = new Dictionary<int, Course>();
    public static List<Course> courseList = new();
    static bool masterListLoaded = false;
    public static string dir = $"{Directory.GetCurrentDirectory()}\\..\\..\\..\\";

    public static void LoadCourses(string ID, string filePath) //just makes the course objects and puts em in a list and a dictionary. That's all it does.
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
                throw new Exception("File unreadable Be sure course information is in this format: crn,courseName,timeStart,timeEnd,description,day1|day2|day3");
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
            if (ID == "0" && masterListLoaded == false) //loads the masterList
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
        if (ID == "0")
        {
            masterListLoaded = true;
        }
        return;
    }

    public static void SaveCourses(List<Course> courses, string ID)
    {
        //File.WriteAllText($"{dir}/Courses/{ID}.txt", string.Empty);
        StreamWriter writer = File.AppendText($"{dir}/Courses/{ID}.txt");
        foreach (Course course in courses)
        {
            writer.WriteLine($"{course.CRN},{course.CourseName},{course.TimeStart},{course.TimeEnd},{course.Description},{string.Join("|", course.Days)}");
        }
        writer.Close();
        for(int i = 0; i < courses.Count; i++)
        {
            courseList.Add(Student.studentSchedule[i]);
        }
    }

}

