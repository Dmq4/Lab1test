using System;

namespace task_9
{
    class Program
    {
        static void Main(string[] args)
        {
            //#9 
            Console.WriteLine("Введите действительные коэффициенты"); 
            Console.WriteLine("a1=?");
            double a_1 = Convert.ToSingle(Console.ReadLine()); 
            Console.WriteLine("a2=?");
            double a_2 = Convert.ToSingle(Console.ReadLine()); 
            Console.WriteLine("a3=?");
            double a_3 = Convert.ToSingle(Console.ReadLine()); 
            Console.WriteLine("b1=?");
            double b_1 = Convert.ToSingle(Console.ReadLine()); 
            Console.WriteLine("b2=?");
            double b_2 = Convert.ToSingle(Console.ReadLine()); 
            Console.WriteLine("b3=?");
            double b_3 = Convert.ToSingle(Console.ReadLine()); 
            Console.WriteLine("c1=?");
            double c_1 = Convert.ToSingle(Console.ReadLine()); 
            Console.WriteLine("c2=?");
            double c_2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("c3=?");
            double c_3 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("d1=?");
            double d_1 = Convert.ToSingle(Console.ReadLine()); 
            Console.WriteLine("d2=?");
            double d_2 = Convert.ToSingle(Console.ReadLine()); 
            Console.WriteLine("d3=?");
            double d_3 = Convert.ToSingle(Console.ReadLine()); 
            double tri_1 = a_1*b_2*c_3; 
            double tri_2 = b_1*a_3*c_2; 
            double tri_3 = a_2*c_1*b_3; 
            double atri_1 = -(a_3*b_2*c_1); 
            double atri_2 = -(b_1*a_2*c_3); 
            double atri_3 = -(a_1*b_3*c_2); 
            double _opr = tri_1+tri_2+tri_3+atri_1+atri_2+atri_3; 
            if(_opr==0){ 
                Console.WriteLine("Определитель равен нулю"); 
            }else { 
                double ex_1 = d_1*(b_2*c_3-b_3*c_2); 
                double ex_2 = d_2*(a_2*c_3-a_3*c_2); 
                double ex_3 = d_3*(a_2*b_3-a_3*b_2); 
                double opr_1 = ex_1-ex_2+ex_3; 
                double rx_1 = d_1*(b_1*c_3-b_3*c_1); 
                double rx_2 = d_2*(a_1*c_3-a_3*c_1); 
                double rx_3 = d_3*(a_1*b_3-a_3*b_1); 
                double opr_2 = -rx_1+rx_2-rx_3; 
                double fx_1 = d_1*(b_1*c_2-b_2*c_1); 
                double fx_2 = d_2*(a_1*c_2-a_2*c_1); 
                double fx_3 = d_3*(a_1*b_2-a_2*b_1); 
                double opr_3 = fx_1-fx_2+fx_3; 
                double x = opr_1/_opr; 
                double y = opr_2/_opr; 
                double z = opr_3/_opr; 
                Console.WriteLine("Переменная x равна {0},Переменная y равна {1},Переменная z равна {2},",x,y,z); 
            } 
                Console.ReadLine();
        }
    }
}
