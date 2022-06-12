using System;

namespace ConsoleApp1
{
    class Program
    {

        public static void Function_chocolate(int money,int wrap)
        {
            //3 обертки - 1 шоколадка. 1 дол - 1 шок
            int choc = money;
            int wr = wrap;
            int result = 0;
            while (choc > 0) 
            {
                choc--;
                wr++;
                if(wr >= 3) 
                {
                    wr = wr - 3;
                    choc++;
                }
                result++;
            }
            Console.WriteLine("Шоколадок {0}, а оберток {1}", result, wr);
            
                
            
        }
        static void Main(string[] args)
        {
            Console.Write("Введите ваше количество оберток, если они есть:");
            int wrap = Convert.ToInt32(Console.ReadLine());
            Console.Write("Количество денег:");
            int mon = Convert.ToInt32(Console.ReadLine());
            Function_chocolate(mon, wrap);

            Console.ReadLine();
        }
    }
}