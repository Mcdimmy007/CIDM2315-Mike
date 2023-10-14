using System;

class Customer
{
    private int cus_id;
    public string cus_name;
    public int cus_age;

    public Customer(int id, string name, int age)
    {
        cus_id = id;
        cus_name = name;
        cus_age = age;
    }

    public void ChangeID(int new_id)
    {
        cus_id = new_id;
    }

    public void PrintCusInformation()
    {
        Console.WriteLine("Customer: " + cus_id + ", Name: " + cus_name + ", Age: " + cus_age);
    }

    public void CompareAge(Customer objCustomer)
    {
        if (this.cus_age > objCustomer.cus_age)
        {
            Console.WriteLine($"{this.cus_name} is older.");
        }
        else if (this.cus_age < objCustomer.cus_age)
        {
            Console.WriteLine($"{objCustomer.cus_name} is older.");
        }
        else
        {
            Console.WriteLine($"{this.cus_name} and {objCustomer.cus_name} are the same age.");
        }
    }
}



class PrintCustomerInformation
{
    static void Main()
    {
        Customer customerOne = new Customer(110, "Alice", 28);
        customerOne.PrintCusInformation();

        Customer customerTwo = new Customer(111, "Bob", 30);
        customerTwo.PrintCusInformation();

        customerOne.ChangeID(220);
        customerTwo.ChangeID(221);

        customerOne.PrintCusInformation();
        customerTwo.PrintCusInformation();

        customerOne.CompareAge(customerTwo);
    }
}
