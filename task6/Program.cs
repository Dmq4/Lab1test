using System;

namespace task_6
{
    class Program
    {
        static void Main(string[] args)
        {
            //#6 
            Console.WriteLine("Введите четырёхзначное число"); 
            int x = Convert.ToInt32(Console.ReadLine()); 
            if(x>=1000 && x<=9999){ 
            double a = x/1000; 
            double b = Math.Truncate((x-a*1000)/100); 
            double c = Math.Truncate(((x-a*1000)-b*100)/10); 
            double d = x-a*1000-b*100-c*10; 
            int result = Convert.ToInt32(a*b*c*d); 
            Console.WriteLine(result); 
            }else{ 
            Console.WriteLine("Ошибка ввода"); 
            } 
            Console.ReadLine();
        }
    }
}
