using System;

namespace Business_Application_Development
{
    class Program
    {
        static void Main(string[] args)
        {
            var today = DateTime.Today;
            var age = today.Year - 2001;
            Console.WriteLine("You are "+age+" years old");
        }
    }
}
