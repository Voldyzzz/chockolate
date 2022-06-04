using System;

namespace ConsoleApp1
{
    class Program
    {

        public static void Function_chocolate(int money) 
        {
            
            int a = 0;
            int amount;
            amount = money;
            int res = 0;
     
            for(int i = 0; i < money; i++) 
            {
                amount -= 3;
                if (amount < 0) 
                {
                    res = money + a;
                }
                else { a++;}
            }
            if (res == 0) Console.WriteLine("You don`t have money my friend :(");
            else if (res == 1) Console.WriteLine("You can buy only 1 chocolate for {0}$", money);
            else Console.WriteLine("For {0}$ you can buy {1} chocolates", money, res);
        }
        static void Main(string[] args)
        {
            int mon = Convert.ToInt32(Console.ReadLine());
            Function_chocolate(mon);

            Console.ReadLine();
        }
    }
}
