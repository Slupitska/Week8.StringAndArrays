using System;

namespace NameReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //Приложение спрашивает у пользователя его имя и показывает его имя задом-наперед
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine();
                        
            for (int i = firstName.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(firstName[i]);
            }
        }
    }
}
