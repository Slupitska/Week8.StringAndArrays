using System;

namespace StringReplace
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string hello = "hello"; //строки - immutable - неизменяемый тип данных
            //string updateHello = hello.Replace('e', '3');
            //udatedHello = updetedHello.Replace('o', '0');
            
            hello = hello.Replace('e', '3');
            hello = hello.Replace('o', '0');

            Console.WriteLine(hello);
            //Console.WriteLine(updateHello);
        }
    }
}
