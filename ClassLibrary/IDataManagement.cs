
namespace FinalProject;

public interface IDataManagement
{
    public void SaveCourses(IEnumerable<Course> courses);
    public IEnumerable<Course> LoadCourses();
}

public class JsonSerializedStorageService : IDataManagement
{
    public IEnumerable<Course> LoadCourses()
    {
        List<Course> courses = new List<Course>();
        if (File.Exists("MasterCourseList.json"))
        {
            var json = File.ReadAllText("MasterCourseList.json");
            courses = System.Text.Json.JsonSerializer.Deserialize<List<Course>>(json);

        }
        return courses;
    }

    public void SaveCourses(IEnumerable<Course> courses)
    {
        var json = System.Text.Json.JsonSerializer.Serialize(courses);
        File.WriteAllText("accounts.json", json);
    }

}