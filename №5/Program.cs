using System;

namespace _5
{
    class Program
    {
        //Используя Visual Studio, создайте проект по шаблону Console Application.
        //Напишите программу, которая решает квадратное уравнение.Пользователь должен ввести
       //коэффициенты а, b и с квадратного уравнения ах2 + bх + с = 0. После чего программа должна
      //вывести на экран все корни этого уравнения или сообщение о том, что их нет.Рассмотреть случаи
      //когда дискриминант(D) квадратного уравнения > 0, когда D<0 и когда D = 0
        static void Main(string[] args)
        {
            double a = 0, b = 0, c = 0, D = 0, x,x1,x2;
            Console.Write("Введите а = ");
            a = double.Parse(Console.ReadLine());
            Console.Write("Введите b = ");
            b = double.Parse(Console.ReadLine());
            Console.Write("Введите c = ");
            c = double.Parse(Console.ReadLine());
            D = (b * b) - 4 * a * c;
            if (D < 0)
            {
                Console.WriteLine("Нету действительных корней !");
            }
            else if (D == 0)
            {
                x = - b / (2 * a);
                Console.WriteLine("х = " + x);
            }
            else if (D > 0)
            {
                x1 = ( -b + Math.Sqrt(D)) / (2 * a);
                x2 = (-b -Math.Sqrt(D)) / (2 * a);
                Console.WriteLine("х1 и х2 = " + x1 + " " + x2);
            }

        }
    }
}
