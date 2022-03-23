namespace ClassLibrary;
public class Course
{
    

}

public class Person
{
    string phone;
    string email;
}
public class Professor : Person
{
    string office;
    string officeHours;
}



public interface IScheduleBlock
{
    public void EditTime(DateTime newTime);
    public void EditProfessor(Person newPerson);
    public void EditCredits(int newCredits);

    
}
