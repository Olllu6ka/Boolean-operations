using System;

namespace Boolean_operations
{
    class Program
    {
      //Используя Visual Studio, создайте проект по шаблону Console Application.
      //Напишите программу, в которой создайте переменнуюa.Значение переменной, а должен задавать
      //пользователь. Если а &lt; 10 то выведите &#39;Верно&#39;, иначе (a&gt;10) выведите &#39;Неверно&#39;.
        static void Main(string[] args)
        {
            int a = 0;
            Console.Write("Введите число от 1 до 20 = ");
            a = int.Parse(Console.ReadLine());
            if (a < 10)
            {
                Console.Write("Вы ввели верно " + a);
            }
            else if (a > 10)
            {
                Console.Write("Вы ввели не верно " + a);
            }
            



        }
    }
}
