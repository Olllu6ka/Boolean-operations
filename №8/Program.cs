using System;

namespace _8
{
    class Program
    {
     //Используя Visual Studio, создайте проект по шаблону Console Application.
     //Напишите программу определения, попадает ли указанное пользователем число от 0 до 100 в
     //числовой промежуток[0 - 14][15 - 35][36 - 50][50 - 100]. Если да, то укажите, в какой именно
     //промежуток. Если пользователь указывает число не входящее ни в один из имеющихся числовых
     //промежутков, то выводится соответствующее сообщение.
        static void Main(string[] args)
        {
            byte Number = 0;
            Console.Write("Введите число = ");
            Number = byte.Parse(Console.ReadLine());
            if (Number >= 0 && Number <=100)
            {
                if (Number >= 0 && Number <= 14)
                {
                    Console.WriteLine("Ваше число попало в первый промежуток " + Number);
                }
                else if (Number >= 15 && Number <=35)
                {
                    Console.WriteLine("Ваше число попало во второй промежуток " + Number);
                }
                else if (Number >=36 && Number <=50)
                {
                    Console.WriteLine("Ваше число попало в третий промежуток " + Number);
                }
                else if (Number >50 && Number <= 100)
                {
                    Console.WriteLine("Ваше число попало в четвертый промежуток " + Number);
                }
            }
            else
            {
                Console.WriteLine("Вы ввели число которое не входит не в один промежуток ");
            }
        }
    }
}
