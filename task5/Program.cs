using System;

namespace task_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //#5 
            Console.WriteLine("Введите катеты прямоугольного треугольника"); 
            double x = Convert.ToSingle(Console.ReadLine()); 
            double y = Convert.ToSingle(Console.ReadLine()); 
            if(x>0 && y>0 ){
            double z = Math.Sqrt(x*x+y*y);  
            double Pl = x*y/2; 
            double Pr = x+y+z; 
            Console.WriteLine("Площадь треугольника:{0},а его периметр:{1}",Pl,Pr);
            }else{
                Console.WriteLine("Ошибка ввода");
            }
            Console.ReadLine();
        }
    }
}
