//Question 1

namespace Wk2Hw2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a letter grade (A, B, C, D, F): ");
        string input= Console.ReadLine();

        int gpa=-1; // this needs a default value to run

        if (input.Length ==1)
        {
            char grade = char.ToUpper(input[0]); // ChatGTP (2023, 08,05). "Please help fix the Char to string error". Used ChatGTP here, was getting the Cannot implicitly convert type 'char' to 'string'. 

        switch (grade)
        {
            case 'A':
                gpa = 4;
                break;
            case 'B':
                gpa = 3;
                break;
            case 'C':
                gpa = 2;
                break;
            case 'D':
                gpa = 1;
                break;
            case 'F':
                gpa = 0;
                break;
            default:
                Console.WriteLine("Wrong Letter Grade!");
                return;
        }
            Console.WriteLine($"GPA Point: {gpa}");
        }
    }

}



// Question 2
namespace Wk2Hw2;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input the first number: ");
        string input1 = Console.ReadLine();

        Console.WriteLine("Please input the second number: ");
        string input2 = Console.ReadLine();

        Console.WriteLine("Please input the third number: ");
        string input3 = Console.ReadLine();

        int num1 = Convert.ToInt32(input1);
        int num2 = Convert.ToInt32(input2);
        int num3 = Convert.ToInt32(input3);

        int smallest = num1; //Bard (2023, 08, 05). How do I determine what the smallest value is?

        if (num2 < smallest)
        {
            smallest = num2;
        }

        if (num3 < smallest)
        {
            smallest =num3;
        }

        Console.WriteLine("The smallest value is: " + smallest);
    }

}


