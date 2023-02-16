using System;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {
            int Number = 0; 
            Console.Write("Введите число какое вы хотите проверить на четность от 0 до 59 = ");
            Number = int.Parse(Console.ReadLine());
            if (Number % 2 == 0)
            {
                Console.Write("Вашек число четное =  " + Number);

                if (Number % 3 == 0 && Number % 6 == 0)
                {
                    Console.WriteLine("\tВаше число можно поделить на 3 и на 6 ");
                }
                else 
                {
                    Console.WriteLine("\tВаше число нельзя поделить на 3 и на 6 ");
                }
            }
            else if (Number % 2 != 0)
            {
                Console.Write("Вашек число не четное =  " + Number);
                if (Number % 3 == 0 && Number % 6 == 0)
                {
                    Console.WriteLine("\tВаше число можно поделить на 3 и на 6 ");
                }
                else 
                {
                    Console.WriteLine("\tВаше число нельзя поделить на 3 и на 6 ");
                }
            }
            
        }
    }
}
