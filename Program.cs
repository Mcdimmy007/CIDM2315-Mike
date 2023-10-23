using System.Collections;
using System.Linq;

namespace Wk9;
class Program
{
    public static void Main (string[] args) {
        // Test Q1
        int[] int_array = {11,23,31,42,53};
        ArraySum(int_array);


        // Input 2d array for Q2
        int[,] array_2d = {
            {1, 2, 3},
            {4, 5, 6},
            {7, 8, 9}
        };


        // Test Q2.1
        PrintAllOddNumber(array_2d);


        // Test Q2.2
        Console.WriteLine($"\nSum of 2d array: {ElementSum(array_2d)}");


         //Test Q2.3
        int[,] Q2_3 = DoubleArray(array_2d);
        Console.WriteLine("The new 2d array:");
        foreach(int num in Q2_3){
                Console.Write(num +" ");
        }
    }

// Q1: calculate the sum of elements in a given int_array
    public static void ArraySum(int[] int_array)
        {
            Console.WriteLine($"Sum of int_array: {int_array.Sum()}");
        }
        
// Q2.1
   public static void PrintAllOddNumber(int[ , ] array_2d){

    for (int i = 0; i < array_2d.GetLength(0); i++)
    {
        for (int j = 0; j < array_2d.GetLength(1); j++)
        {
            int element = array_2d[i, j];

            if (IsOdd(element))
            {
                Console.Write(element + " ");
            }
        }
    }
}
public static bool IsOdd(int number)
{
    return number % 2 !=0;

}

//Q2.2

public static int ElementSum(int[ , ] array_2d){
         int sum = 0;

    for (int row = 0; row < array_2d.GetLength(0); row++)
    {
        for (int col = 0; col < array_2d.GetLength(1); col++)
        {
            sum += array_2d[row, col];
        }
    }

    return sum;
    }


// Q2.3: given a 2d array, double its element values and return it 
    public static int[ , ] DoubleArray(int[ , ] array_2d){
    int rows = array_2d.GetLength(0);
    int cols = array_2d.GetLength(1);

    int[,] doubleArray = new int[rows, cols];

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            doubleArray[i, j] = array_2d[i, j] * 2;
        }
    }

    return doubleArray;
         
       
    }  

}


