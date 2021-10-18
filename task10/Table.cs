using System;
using System.Collections;

namespace Table 
{
    class Program
    {

         
        
         static void Main(string[] args)
        {
            //#10
            ArrayList list = new ();
            
            {
                Console.WriteLine("Введите данные первого:");
                Console.WriteLine("ФИО?");
                string fio_1 = Console.ReadLine();
                Console.WriteLine("Тип(С,T):");
                string tip_1 = Console.ReadLine();
                    
                Console.WriteLine("Год рождения:");
                int gr_1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Опыт(работы):");
                int exp_1 = Convert.ToInt32(Console.ReadLine());
                        
                    
                Console.WriteLine("Введите данные второго:");
                Console.WriteLine("ФИО?");
                string fio_2 = Console.ReadLine();
                Console.WriteLine("Тип(С,T):");
                string tip_2 = Console.ReadLine();
                    
                Console.WriteLine("Год рождения:");
                int gr_2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Опыт(работы):");
                int exp_2 = Convert.ToInt32(Console.ReadLine());
                        
                Console.WriteLine("Введите данные третьего:");
                Console.WriteLine("ФИО?");
                string fio_3 = Console.ReadLine();
                Console.WriteLine("Тип(С,T):");
                string tip_3 = Console.ReadLine();
                   
                Console.WriteLine("Год рождения:");
                int gr_3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Опыт(работы):");
                int exp_3 = Convert.ToInt32(Console.ReadLine());
                            
                Console.WriteLine(new String('-', 76));
                Console.WriteLine($"{"|Состав спортклуба",-75}|");
                Console.WriteLine(new String('-', 76));
                Console.WriteLine($"{"|ФИО",-25}|{"Тип ",-12}|{"Год рождения",-20}|{"Опыт(работы)",-15}|");
                Console.WriteLine(new String('-', 76));
                Console.WriteLine($"|{fio_1,-24}|{tip_1,-12}|{gr_1,-20}|{exp_1,-15}|");
                Console.WriteLine(new String('-', 76));
                Console.WriteLine($"|{fio_2,-24}|{tip_2,-12}|{gr_2,-20}|{exp_2,-15}|");
                Console.WriteLine(new String('-', 76));
                Console.WriteLine($"|{fio_3,-24}|{tip_3,-12}|{gr_3,-20}|{exp_3,-15}|");
                Console.WriteLine(new String('-', 76));
                Console.WriteLine($"{"|Перечисляемый тип: Т – тренер, С - спортсмен",-75}|");
                Console.WriteLine(new String('-', 76));
                
            }
                Console.ReadKey(true);



        }


    }
}