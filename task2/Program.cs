using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //#2 
            Console.WriteLine("Введите число секунд"); 
            int sec = Convert.ToInt32(Console.ReadLine()); 
            if(sec<84600 && sec>=0){ 
                double hour = sec/3600; 
                int ohour = Convert.ToInt32(hour); 
                double min = (sec-hour*3600)/60; 
                int omin = Convert.ToInt32(min); 
                Console.WriteLine("Часов:{0},Минут:{1}.",ohour,omin); 
                }else if(sec>84600){ 
                Console.WriteLine("Времени прошло более суток"); 
                }else{ 
                Console.WriteLine("Ошибка ввода"); 
                } 
                Console.ReadLine();
        }
    }
}
