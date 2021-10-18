using System;

namespace task_7
{
    class Program
    {
        static void Main(string[] args)
        {
            //#7 
            Console.WriteLine("Введите трёхзначное целое число"); 
            int x = Convert.ToInt32(Console.ReadLine()); 
            if(x>=100 && x<=999){ 
            double a = x/100; 
            double b = Math.Truncate((x-a*100)/10); 
            double c = x-a*100-b*10; 
            double reversed = c*100+b*10+a; 
            Console.WriteLine(reversed); 
            }else{ 
            Console.WriteLine("Ошибка ввода"); 
            } 
            Console.ReadLine();
        }
    }

}
