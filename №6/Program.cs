using System;

namespace _6
{
    class Program
    {
     //Используя Visual Studio, создайте проект по шаблону Console Application.
     //Напишите программу, которая определяет, является ли год високосным. Пользователь вводит год.
     //Программа должна вывести на экран ответ, является ли год високосным. Подсказка.Обычно
     //каждый год, который делится на 4, — это високосный год, кроме лет столетий (делящихся на 100).
     //Но среди последних год, делящийся на 400, также считается високосным
        static void Main(string[] args)
        {
            int Year = 0;
            Console.Write("Введите ваш год = ");
            Year = int.Parse(Console.ReadLine());
            if ( Year % 4 == 0 )
            {
                Console.WriteLine("Ваш год высокосный");
            }
            else if (Year % 100 == 0)
            {
                Console.WriteLine("Ваш год высокосный");
            }
            else if ( Year % 400 == 0)
            {
                Console.WriteLine("Ваш год высокосный");
            }
            else
            {
                Console.WriteLine("Ваш год не высокосный");
            }
        }
    }
}
