//Question 1
/*
namespace Wk3Hw;
class Program
{
    static void Main(string[] args)
    {
      
        Console.WriteLine("Input an integer: ");
        int N= Convert.ToInt16 (Console.ReadLine());

        bool primeNum = true;
        for (int i = 2; i <= N / 2; i++) {
            if (N % i == 0) {
                primeNum = false;
                break;
            }
        }

        if (primeNum) {
            Console.WriteLine("{0} is a prime number", N);
        } else {
            Console.WriteLine("{0} is a non-prime number", N);
        }
    }
}  
*/

//Question 2

/*
namespace Wk3Hw;
class Program
{
    static void Main(string[] args)
    {
      Console.WriteLine("Please input N: ");
        int N = Convert.ToInt16 (Console.ReadLine());

        for (int row = 1; row <= N; row++)
        {
            for (int col= 1; col <= N; col++)
            {
                Console.Write("# ");
            }
            Console.WriteLine();
        }
    }
       
}
*/

// Question 3 


namespace Wk3Hw;
class Program
{
    static void Main(string[] args)
    {
      Console.WriteLine("Assign an int value to N: ");
    int N = Convert.ToInt16 (Console.ReadLine());

    for (int row = 0; row<N; row++)
    {
        for(int col = 0; col<= row; col++) // Bard (2023, 09, 12). How do I get the pattern for 1 increment for each line of N?
        {
            Console.Write("* ");
        }
        Console.WriteLine();
    }
    
    }
}    



    
