using System;

namespace Проверочные_задачи_к_уроку___2
{
    class Program
    {
        static void Main(string[] args)
        {
            byte a = 10, b = 20, function = 0;
            string ArithmeticOperation = null;
            Console.Write("Каркулятор !" + "Дано вам два числа a = 10,b = 20 "
                + "\nВыберите арифметическое действие - +,-,*,/ = ");
            ArithmeticOperation = Console.ReadLine();
            Console.Write("Выберите над каким числом вы хотите выполнить действие = "+ "Если а то введите 1, если b то 2 = ");
            function = byte.Parse(Console.ReadLine());
            switch (function)
            {
                case 1:
                    switch (ArithmeticOperation)
                    {
                        case "+":
                            Console.WriteLine("Сложение = " + (a + b));
                            break;
                        case "-":
                            Console.WriteLine("Вычитание = " + (a - b));
                            break;
                        case "*":
                            Console.WriteLine("Умножение = " + (a * b));
                            break;
                        case "/":
                            double c = 10, d = 20;
                            Console.WriteLine("Деление = " + (c / d));
                            break;

                    }
                    break;
                case 2:
                    switch (ArithmeticOperation)
                    {
                        case "+":
                            Console.WriteLine("Сложение = " + (b + a));
                            break;
                        case "-":
                            Console.WriteLine("Вычитание = " + (b - a));
                            break;
                        case "*":
                            Console.WriteLine("Умножение = " + (b * a));
                            break;
                        case "/":
                            Console.WriteLine("Деление = " + (b % a)); 
                            break;

                    }
                    break;
            }
           
        }
    }
}
