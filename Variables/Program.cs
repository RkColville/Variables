using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            string someName = "Robert";
            int age = 49;
            bool isMarried = true;
            char favoriteLetter = 'x';
            double specialNumber = 152.35;
            decimal really = 3.14M;





            Console.WriteLine($"His name is {someName}. {someName} is {age} years old.");
            Console.WriteLine($"Is Robert married? {isMarried}, he is married.");
            Console.WriteLine($"{someName}'s favorite letter is {favoriteLetter}.");
            Console.WriteLine($"{someName}'s favorite number is {specialNumber}");
            Console.WriteLine($"{someName}'s favorite decimal is {really}");
        }
    }
}
