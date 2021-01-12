using System;

namespace Business_Application_Development
{
    class Program
    {
        static void Main(string[] args)
        {
            var today = DateTime.Today;
            Console.WriteLine("Enter Your Age : ");
            String Age = Console.ReadLine();
            int yourAge = int.Parse(Age);

            int yearOfBirth = today.Year - yourAge;
            Console.WriteLine("You were born in : "+ yearOfBirth);
        }
    }
}
