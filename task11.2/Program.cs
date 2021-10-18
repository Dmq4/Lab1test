using System;

namespace task_11._2
{
    class Program
    {
        static void Main(string[] args)
        {
            //#11.2 
            Console.WriteLine("Введите a,b,x"); 
            Console.WriteLine("x=?");
            double x = Convert.ToSingle(Console.ReadLine()); 
            Console.WriteLine("a=?");
            double a = Convert.ToSingle(Console.ReadLine()); 
            Console.WriteLine("b=?");
            double b = Convert.ToSingle(Console.ReadLine()); 
            double e = 2.71; 
            double first = Math.Pow(x,2); 
            double chisl = b*first-a; 
            double st_1 = a*x; 
            double second = Math.Pow(e,st_1); 
            double znam = second-1; 
            if(znam!=0){ 
                double result_Q = chisl/znam; 
                Console.WriteLine("Ответ:{0}",result_Q); 
            }else{ 
                Console.WriteLine("Знаменатель равен нулю,нет решений"); 
            } 
            Console.ReadLine();
        }

    }
}
