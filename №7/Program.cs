using System;

namespace _7
{
    class Program
    {
     //Используя Visual Studio, создайте проект по шаблону Console Application.
     //Напишите программу - консольный калькулятор. Создайте две переменные с именами operand1 и
     //operand2. Задайте переменным некоторые произвольные значения.Предложите пользователю
     //ввести знак арифметической операции. Примите значение введенное пользователем и поместите
     //его в строковую переменную sign.Для организации выбора алгоритма вычислительного процесса,
     //используйте переключатель switch. Выведите на экран результат выполнения арифметической
     //операции.В случае использования операции деления, организуйте проверку попытки деления на
     //ноль. И если таковая имеется, то отмените выполнение арифметической операции и уведомите об
     //ошибке пользователя
        static void Main(string[] args)
        {
            double operand1 = 0, operand2 = 0;
            string sign = null;
            Console.Write("Введите первое число = ");
            operand1 = double.Parse(Console.ReadLine());
            Console.Write("Введите второе число = ");
            operand2 = double.Parse(Console.ReadLine());
            Console.Write("\nАрифметическое действия: + , - , / , *" + "\nВыберите действие = ");
            sign = Console.ReadLine();
            switch (sign)
            {
                case  "+":
                    Console.WriteLine(operand1 + operand2 + " = Cумма сложенных вами чисел");
                    break;
                case "-":
                    Console.WriteLine(operand1 - operand2 + " = Cумма вычитанных вами чисел");
                    break;
                case "/":
                    if (operand2 == 0)
                        Console.WriteLine("Ошибка");
                    else
                        Console.WriteLine(operand1 / operand2 + " = Cумма поделённых вами чисел");
                    break;
                case "*":
                    Console.WriteLine(operand1 * operand2 + " = Cумма умноженных вами чисел");
                    break;
                default:
                    Console.WriteLine("Ошибка ! Вы выбрали неизветсное действие");
                    break;

                    Console.ReadLine();
            }

        }
    }
}
