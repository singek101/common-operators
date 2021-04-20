using System;

namespace common_operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Arthmentic operators + - / % *
            //terary opreators 
            int x = 12;
            int y = 11;
            int  result = x < y ? x + y : x++;
            Console.WriteLine(result);
            Console.WriteLine("hello world");
        }
    }
}
