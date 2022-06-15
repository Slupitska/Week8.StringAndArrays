using System;

namespace StringAndArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //string someString = "Hello World!";
            //int someNumber = 5;
            //bool someBool = true;
            //char someChar = `a`;

            //int stringLength = someString.Length;
            //Console.WriteLine(stringLength);

            //Задание 1.
            //Приложение просит пользователя ввести имя и показывает, сколько букв в имени пользователя

            // Способ I

            {
                Console.WriteLine("Enter your first name:");
                string firstName = Console.ReadLine();
                int firstNameLength = firstName.Length;
                Console.WriteLine($"Your first name is {firstName.Length} characters long.");
            }

            // Способ II 
            // 
            //    Console.WriteLine("Enter your first name:");
            //    string firstName = Console.ReadLine();
            //    Console.WriteLine($"Your first name is {firstName.Length} characters long.");
            // 

        }
    }
}
