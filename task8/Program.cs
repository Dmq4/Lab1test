using System;

namespace task_8
{
    class Program
    {
        static void Main(string[] args)
        {
            //#8 
            Console.WriteLine("Введите действительное число x"); 
            Console.WriteLine("3x^4-5x^3+2x^2-x+7"); 
            double x = Convert.ToSingle(Console.ReadLine()); 
            double result = (((3*x-5)*x+2)*x-1)*x+7; 
            Console.WriteLine(result); 
            Console.ReadLine();
        }
    }
}
