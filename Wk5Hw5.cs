/*namespace Wk5Hw;
class Program
{
    static void Main(string[] args)
    {
      Console.Write("a= ");
      int firstnum = Convert.ToInt16(Console.ReadLine());

      Console.Write("b= ");
      int secondnum = Convert.ToInt16(Console.ReadLine());

      int largestnum = TheLargestNumber(firstnum, secondnum);

      Console.WriteLine("The largest number is: {0}", largestnum);

    }
    static int TheLargestNumber(int firstnum, int secondnum)
    {
    if (firstnum > secondnum)
    {
        return firstnum;
    }
    else
    {
        return secondnum;
    }
    }
}
*/

/*

namespace Wk5Hw
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a= ");
            int firstnum = Convert.ToInt16(Console.ReadLine());

            Console.Write("b= ");
            int secondnum = Convert.ToInt16(Console.ReadLine());

            Console.Write("c= ");
            int thirdnum = Convert.ToInt16(Console.ReadLine());

            Console.Write("d= ");
            int forthnum = Convert.ToInt16(Console.ReadLine());

            int largestOfFour = TheLargestNumber(firstnum, secondnum, thirdnum, forthnum);

            Console.WriteLine("The largest number is: {0}", largestOfFour);
        }

        static int TheLargestNumber(int firstnum, int secondnum, int thirdnum, int fourthnum)
        {
            int largestnum = firstnum;

            if (secondnum > largestnum)
            {
                largestnum = secondnum;
            }

            if (thirdnum > largestnum)
            {
                largestnum = thirdnum;
            }

            if (fourthnum > largestnum)
            {
                largestnum = fourthnum;
            }

            return largestnum;
        }
    }
}
*/


namespace Wk5Hw
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateAccount();
        }
        static bool CheckAge(int birthYear)
        {
            int currentYear = DateTime.Now.Year;
            int age = currentYear - birthYear;

            return age >= 18;
        }

        static void CreateAccount()
        {
            Console.WriteLine("Welcome to the Registration Page");

            Console.Write("Enter Your preferred Username: ");
            string username = Console.ReadLine();

            Console.Write("Enter Your chosen Password: ");
            string password = Console.ReadLine();  

            Console.Write("Enter Your password again: ");
            string passwordRepeat = Console.ReadLine();       // ChatGPT 9/25/2023 How do I verify password?

            Console.Write("Enter your Birth Year: ");
            int birthYear;
            if (int.TryParse(Console.ReadLine(), out birthYear)) // Convert.ToInt16(Console.ReadLine()) did not work here, so I used TryParse
            {
                if (CheckAge(birthYear))
                {
                    if (password == passwordRepeat)
                    {
                        Console.WriteLine("Account is created successfully!");
                    }
                    else
                    {
                        Console.WriteLine("Wrong Password! Try again.");
                    }
                }
                else
                {
                    Console.WriteLine("Account creation failed. Must be at least 18 years old!");
                }
            }
            else
            {
                Console.WriteLine("Try Again! Please type in Year of Birth only");
            }
        }

        
    }
}



