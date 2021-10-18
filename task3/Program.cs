using System;

namespace task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            //#3 
            Console.WriteLine("Введите время в 12 часовом формате часы,минуты, секунды"); 
            int h = Convert.ToInt32(Console.ReadLine()); 
            int m = Convert.ToInt32(Console.ReadLine()); 
            int s = Convert.ToInt32(Console.ReadLine()); 
            if(h<=11 && h>=0 && m<=59 && m>=0 && s<=59 && s>=0){ 
            double time = h*3600+m*60+s; 
            double arc = 360*time/12/3600; 

            Console.WriteLine("Угол между положением стрелки в начале суток и её положением сейчас:{0}",arc); 
            }else{ 
            Console.WriteLine("Ошибка ввода"); 
            }
            Console.ReadLine();
        }

    }
}
