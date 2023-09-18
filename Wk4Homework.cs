/* Q1
namespace Week4Hw;
class Program
{
    static void Main(string[] args)
    {
        int first_num;
        int second_num;

       	Console.Write("a= ");
        first_num = Convert.ToInt16(Console.ReadLine());

        Console.Write("b= ");
        second_num = Convert.ToInt16(Console.ReadLine());

        int largest = first_num;

        if (second_num > largest)
        {
            largest = second_num;
        }

        Console.WriteLine("The largest number is: {0}", largest);
    }
}

*/

//Q2

namespace Week4Hw;
class Program
{
    static void Main(string[] args)
    {
        
        PrintTriangle(5, "left");
        PrintTriangle(5, "right");

    }

    static void PrintTriangle(int N, string shape)
    {
        if (shape == "left")
        {
            Console.WriteLine($"N is {N}, shape is {shape}");
            PrintLeftSideTriangle(N);
        }

        else if (shape == "right")
        {
            Console.WriteLine($"N is {N}, shape is {shape}");
            PrintRightSideTriangle(N);
        }
    }
    static void PrintLeftSideTriangle(int N)
    {
        for (int i = 1; i <= N; i++)
        {
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

     static void PrintRightSideTriangle(int N)
    {
        for (int i = 1; i <= N; i++)
        {
            for (int j = 1; j <= N-i+1; j++) // Bard 09/18/2023. How do I make the asterisks aligned to the right?
            {
                Console.Write(" ");
            }
            for (int j = N-i + 1; j <= N; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }

}

