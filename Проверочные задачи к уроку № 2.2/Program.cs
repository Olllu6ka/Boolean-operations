using System;

namespace Проверочные_задачи_к_уроку___2._2
{
    class Program
    {
     //Дана длина 𝐿 окружности.Найти ее радиус 𝑟 и площадь 𝑆 круга, ограниченного этой окружностью, 
     //учитывая, что 𝐿 = 2𝜋r, 𝑆 = 𝜋𝑟2
     //В качестве значения 𝜋 использовать 3.14
        static void Main(string[] args)
        {
            double R = 0, P = 3.14;
            string variant = null,L = null,S = null;
            Console.Write("Введите радиус = ");
            R = double.Parse(Console.ReadLine());
            Console.Write("Выберите что вы хотите узнать" + "\tДано - Длина окружности: L, площадь S" + 
                "\nВведите что вы хотите узнать (Напишите букву на английском и большую) = ");
            variant = Console.ReadLine();
            switch (variant)
            {
                case "L":
                    Console.WriteLine("Длина окружности = " + (2 * P * R));
                    break;
                case "S":
                    Console.WriteLine("Площадь  = " + (P * (R * 2)));
                    break;
                default:
                    Console.WriteLine("Нету такого варианта !");
                    break;
            }
        }
        
    }
               
}
