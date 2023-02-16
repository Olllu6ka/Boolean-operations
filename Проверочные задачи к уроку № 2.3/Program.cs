using System;

namespace Проверочные_задачи_к_уроку___2._3
{
    class Program
    {
     //Создать программу, которая запрашивает имя пользователя и здоровается с ним.Для вывода
     //информации использовать 3 варианта конкатенации строк
        static void Main(string[] args)
        {
            string name;
            string dop = "Вы красавчик !";
            Console.Write("Введите ваше имя = ");
            name = Console.ReadLine();
            Console.WriteLine("///////////////////////// 1 Вариатн - Смена регистра");
            Console.WriteLine(name.ToUpper());
            Console.WriteLine("///////////////////////// 2 Вариатн - Обрезание строки");
            name = name.Substring(1);
            Console.WriteLine(name);
            Console.WriteLine("///////////////////////// 3 Вариатн - Замена");
            name = name.Replace(name, "Сломалась консоль");
            Console.WriteLine(name);


        }
    }
}
