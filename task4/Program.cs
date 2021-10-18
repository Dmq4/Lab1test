using System;

namespace task_4
{
    class Program
    {
        static void Main(string[] args)
        {
            //#4 
            Console.WriteLine("Введите два целых числа"); 
            int x = Convert.ToInt32(Console.ReadLine()); 
            int y = Convert.ToInt32(Console.ReadLine()); 
            x = x+y; 
            y = x-y; 
            x = x-y; 
            Console.WriteLine(x); 
            Console.WriteLine(y); 
            Console.ReadLine();
        }
    }
}
