using System;

namespace _9
{
    class Program
    {
     //Используя Visual Studio, создайте проект по шаблону ConsoleApplication.
     //Напишите программу русско-английский переводчик.Программа знает 10 слов о погоде.Требуется,
     //чтобы пользователь вводил слово на русском языке, а программа давала ему перевод этого слова
     //на английском языке. Если пользователь ввел слово, для которого отсутствует перевод, то следует
     //вывести сообщение, что такого слова нет
        static void Main(string[] args)
        {
            string Word = null;
            Console.Write("Добро пожаловать !" + "\nВ словарик Английского от Владика по погоде"+
                "\nЯ знаю такие слова на Русском - 1)Солнечный"+"\t2)Облачно"+"\t3)Дождливо" + "\t4)Ветрено" + 
                "\t 5)Мокрый снег" + "\n6)Холодно" +"\t 7)Тепло" +"\t 8)Жарко"+"\t 9)Прохладно"+"\t 10)Очень холодно" +
                "\nВведите слово которое хотите перевести = ");
            Word = Console.ReadLine();
            if ("Солнечный" == Word)
            {
                Console.WriteLine("Перевод = Sunny" + "\tВаше слово на русском = " + Word);
            }
            else if ("Облачно" == Word)
            {
                Console.WriteLine("Перевод = Cloudy" + "\tВаше слово на русском = " + Word);
            }
            else if ("Дождливо" == Word)
            {
                Console.WriteLine("Перевод = Rainy" + "\tВаше слово на русском = " + Word);
            }
            else if ("Ветрено" == Word)
            {
                Console.WriteLine("Перевод = Windy" + "\tВаше слово на русском = " + Word);
            }
            else if ("Мокрый снег" == Word)
            {
                Console.WriteLine("Перевод = Wet snow" + "\tВаше слово на русском = " + Word);
            }
            else if ("Холодно" == Word)
            {
                Console.WriteLine("Перевод = Cold" + "\tВаше слово на русском = " + Word);
            }
            else if ("Тепло" == Word)
            {
                Console.WriteLine("Перевод = Warm" + "\tВаше слово на русском = " + Word);
            }
            else if ("Жарко" == Word)
            {
                Console.WriteLine("Перевод = Hot" + "\tВаше слово на русском = " + Word);
            }
            else if ("Прохладно" == Word)
            {
                Console.WriteLine("Перевод = Chilly" + "\tВаше слово на русском = " + Word);
            }
            else if ("Очень холодно" == Word)
            {
                Console.WriteLine("Перевод = Very cold" + "\tВаше слово на русском = " + Word);
            }
        }
    }
}
