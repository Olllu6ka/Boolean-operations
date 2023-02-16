using System;

namespace _3
{
    class Program
    {
     //Используя Visual Studio, создайте проект по шаблону Console Application.
     //Напишите программу, в которой создайте переменную min.Значение переменной должен задавать
     //пользователь, интервал допустимых значений 0 до 59, необходимо организовать проверку на ввод
     //допустимого интервала.Определите в какую четверть часа попадает значение переменной (в
     //первую, вторую, третью или четвертую)
        static void Main(string[] args)
        {
            int min = 0;
            Console.Write("Введите число с диапозоном от 0 до 59 = ");
            min = int.Parse(Console.ReadLine());
            if (min >= 0 && min <= 59)
            {
                if (min >= 0 && min < 15)
                {
                    Console.WriteLine("Вы попали в 1 четверть");
                }
                else if (min >= 15 && min < 30)
                {
                    Console.WriteLine("Вы попали в 2 четверть");
                }
                else if (min >= 30 && min < 45)
                {
                    Console.WriteLine("Вы попали в 3 четверть");
                }
                else if (min >= 45 && min < 59)
                {
                    Console.WriteLine("Вы попали в 4 четверть");
                }
            }
            else
            {
                Console.WriteLine("Вы не попали в диапозон заданых чисел");
            }
        }
    }
}
