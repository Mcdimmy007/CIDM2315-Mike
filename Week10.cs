using System.Linq;

namespace Wk10class2;
public class Student
{
    
    private int studentID;
    private string studentName;
    public static List<Student> student_list = new List<Student>();
    public Student(int studentID, string studentName)
    {
        this.studentID = studentID;
        this.studentName = studentName;
        student_list.Add(this);
    }
    public void PrintInfo()
    {
        Console.WriteLine($"Student ID: {studentID},  Student Name: {studentName}");
    }
    public int GetStudentID()
    {
        return studentID;
    }
    public string GetStudentName()
    {
        return studentName;
    }
}




public class Program
{
    public static void Main()
    {
        Student student1 = new Student(111, "Alice");
        Student student2 = new Student(222, "Bob");
        Student student3 = new Student(111, "Cathy");
        Student student4 = new Student(111, "David");

        Dictionary<string, double> gradebook = new Dictionary<string, double>();
        
        gradebook.Add("Alice", 4.0);
        gradebook.Add("Bob", 3.6);
        gradebook.Add("Cathy", 2.5);
        gradebook.Add("David", 1.8);

        if (!gradebook.ContainsKey("Tom"))
        {
            gradebook.Add("Tom", 3.3);
        }
        double sumGPA = gradebook.Values.Sum();
        double averageGPA  = sumGPA/gradebook.Count();
        
        Console.WriteLine($"The average GPA is {averageGPA}");

        foreach (var student in Student.student_list)
        {
            if (gradebook.ContainsKey(student.GetStudentName()) && gradebook[student.GetStudentName()]> averageGPA) // Used ChatGPT here to complete the if- statement 10/30/2023
            {
                student.PrintInfo();
            }
        }
    }
}