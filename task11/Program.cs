using System;

namespace task_11
{
    class Program
    {
        static void Main(string[] args)
        {
            //#11.1 
                Console.WriteLine("Введите x,a,b"); 
                Console.WriteLine("x=?");
                double x = Convert.ToSingle(Console.ReadLine()); 
                Console.WriteLine("a=?");
                double a = Convert.ToSingle(Console.ReadLine()); 
                Console.WriteLine("b=?");
                double b = Convert.ToSingle(Console.ReadLine()); 
                double first = Math.Pow(x,3); 
                double radians = Math.Pow((x+b),2) * (Math.PI/180); 
                double second = Math.Tan(radians); 
                double third_2 = Math.Sqrt(x+b); 
                double third = a/third_2; 
                double result = first*second+third; 

                if(x>-b && radians!=Math.PI/2 && radians!=3*Math.PI/2){ 
                    Console.WriteLine("Ответ:{0}",result); 
                }else{ 
                    Console.WriteLine("Не имееет решений при заданных переменных"); 
                } 
                Console.ReadLine();

               
        }
    }
}
