class Student{
    public string studentName;
    public string classEnroll;
    private double studentGrade;

    public void SetGrade(double newGrade){
        studentGrade = newGrade;
    }

    public double GetGrade(){
        return studentGrade;
    }
}

class Professor{
    public string profName;
    public string classTeach;
    private double salary;

    public void SetSalary(double salary_amount){
        salary = salary_amount;
    }

    public double GetSalary(){
        return salary;
    }
}

namespace Wk7Hw;
class Program
{
    static void Main(string[] args)
    {
        Professor alice = new Professor();
        alice.profName = "Alice";
        alice.classTeach = "Java";
        alice.SetSalary(9000); 

        Professor bob = new Professor();
        bob.profName = "Bob";
        bob.classTeach = "Math";
        bob.SetSalary(8000);

        Student lisa = new Student();
        lisa.studentName = "Lisa";
        lisa.classEnroll = "Java";
        lisa.SetGrade(90); 

        Student tom = new Student();
        tom.studentName = "Tom";
        tom.classEnroll = "Math";
        tom.SetGrade(80);

        Console.WriteLine("*********************************************************************");
        Console.WriteLine("Professor " + alice.profName + " teaches: " + alice.classTeach + ", and the Salary is: $" + alice.GetSalary());
        Console.WriteLine("Professor " + bob.profName +  " teaches: " + bob.classTeach + ", and the Salary is: $" + bob.GetSalary());

        Console.WriteLine("Student " + lisa.studentName + " is enrolled in: " + lisa.classEnroll + ", and the Grade is: " + lisa.GetGrade());
        Console.WriteLine("Student " + tom.studentName + " is enrolled in: " + tom.classEnroll + ", and the Grade is: " + tom.GetGrade());

        double salaryDifference = alice.GetSalary() - bob.GetSalary();
        Console.WriteLine("The Salary Difference Between Professor Alice and Bob is: $" + salaryDifference);

        double gradeTotal = lisa.GetGrade() + tom.GetGrade();
        Console.WriteLine("The Total grade bewteen Lisa and Tom is: " + gradeTotal);
        Console.WriteLine("*********************************************************************");


    }
}
