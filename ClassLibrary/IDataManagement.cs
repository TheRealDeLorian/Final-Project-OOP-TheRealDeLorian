
namespace FinalProject;

public interface IDataManagement
{
    public void SaveCourses(List<Course> courses, int ID);
    public List<Course> LoadCourses(int ID);

   
}

public class CSVDataManagement : IDataManagement
{
    public List<Course> LoadCourses(int ID)
    {
        var courses = new List<Course>();
        var CRN = "";
        var CourseName = "";
        var TimeStart = "0:00";
        var TimeEnd = "0:00";
        var Description = "";
        string[] Days;
        string filePath = Path.Combine("Courses", $"{ID}.csv");

        foreach (var line in File.ReadAllLines(filePath))
        {
            var courseInfoParts = line.Split(','); //TAKE OUT IFS
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
            courses.Add(course);
        }
        return courses;
    }

    public void SaveCourses(List<Course> courses, int ID)
    {
        throw new NotImplementedException();
    }
}