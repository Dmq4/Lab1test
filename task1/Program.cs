using System;

namespace task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //#1 
            Console.WriteLine("Введите действительное число"); 
            double x = Convert.ToDouble(Console.ReadLine()); 
            double d = Math.Floor((x-(int)x)*10); 
            Console.WriteLine(d); 
            Console.ReadLine();
        }
    }
}
