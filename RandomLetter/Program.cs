using System;

namespace RandomLetter
{
    class Program
    {
        static void Main(string[] args)
        {   //*RandomLetter. Приложение спрашивает у пользователя его имя и 
            //показывает случайную букву из имени пользователя

            Random rnd = new Random();
            string userName;

            Console.WriteLine("Enter your name:");
            userName = Console.ReadLine();
            int length = userName.Length;

            length = rnd.Next(0, length);

            Console.WriteLine(userName[length]);
            
        }
    }
}
