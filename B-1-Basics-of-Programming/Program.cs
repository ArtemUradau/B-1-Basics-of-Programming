using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_1_Basics_of_Programming
{
    class Program
    {
        static void Main(string[] args)
        {
            const int adultage = 18;

            Console.WriteLine("Введите имя: ");
            string name = Console.ReadLine();
            Console.WriteLine("Введите фамилию: ");
            string surname = Console.ReadLine();
            Console.WriteLine("Введите возраст: ");
            int age = Int32.Parse(Console.ReadLine());
            if(age<adultage)
            {
                Console.WriteLine($"{name} {surname}, есть ли разрешение от родителей?(1-Y/2-N)");
                int per = Int32.Parse(Console.ReadLine());
                if(per==2)
                {
                    Console.WriteLine($"{name} {surname}, идите домой");
                    Environment.Exit(0);
                }
            }

             Console.WriteLine("Все ли документы готовы?(1-Y/2-N)");
             int doc = Int32.Parse(Console.ReadLine());
             if (doc == 2)
             { 
               Console.WriteLine($"{name} {surname}, идите домой");
               Environment.Exit(0);
             }

             Console.WriteLine("Есть ли среди поданных документов фотография?(1-Y/2-N)");
             int ph = Int32.Parse(Console.ReadLine());
             if (ph == 2)
             { 
               Console.WriteLine($"{name} {surname}, идите в фотокомнату");
             }
             Console.WriteLine("Фотография сделана более трех месяцев назад?(1-Y/2-N)");
             int ph2 = Int32.Parse(Console.ReadLine());
             if (ph2 == 1)
             { 
               Console.WriteLine($"{name} {surname}, идите в фотокомнату");
             }
             Console.WriteLine("Эта фотография использовалась на паспорт?(1-Y/2-N)");
             int ph3 = Int32.Parse(Console.ReadLine());
             if (ph3 == 1)
             { 
               Console.WriteLine($"{name} {surname}, идите в фотокомнату");
             }
             Console.WriteLine("Фотография вклеена?(1-Y/2-N)");
             int ph4 = Int32.Parse(Console.ReadLine());
             if (ph4 == 2)
             { 
               Console.WriteLine("Вы вклеили фото");
             }
                Console.WriteLine("Вы оплатили");
                Console.ReadKey();
        }
    }
}
