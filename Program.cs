using System;

namespace Business_Application_Development
{
    class Program
    {
        static void Main(string[] args)
        {
            var today = DateTime.Today;
            Console.WriteLine("Enter Your Age : ");
            var Age = Console.ReadLine();
            var yourAge = int.Parse(Age);

            var yearOfBirth = today.Year - yourAge;
            Console.WriteLine("You were born in : "+ yearOfBirth);
        }
    }
}
