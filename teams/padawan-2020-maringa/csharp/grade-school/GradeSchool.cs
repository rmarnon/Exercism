using System.Collections.Generic;
using System.Linq;

public class GradeSchool
{
    private readonly List<Student> Students = new List<Student>();

    public void Add(string student, int grade)
    {
        Students.Add(new Student { Name = student, Grade = grade });
    }

    public IEnumerable<string> Roster() => Students.OrderBy(x => x.Grade).ThenBy(x => x.Name).Select(x => x.Name);        

    public IEnumerable<string> Grade(int grade) => Students.Where(x => x.Grade == grade).OrderBy(x => x.Name).Select(x => x.Name);      
}

 public class Student
{
    public string Name { get; set; }
    public int Grade { get; set; }      
}