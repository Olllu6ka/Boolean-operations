using System;

namespace _10
{
    class Program
    {
      //Используя Visual Studio, создайте проект по шаблону ConsoleApplication.Напишите программу
      //расчета начисления премий сотрудникам.Премии рассчитываются согласно выслуге лет. Если
      //выслуга до 5 лет, премия составляет 10% от заработной платы.Если выслуга от 5 лет (включительно)
      //до 10 лет, премия составляет 15% от заработной платы.Если выслуга от 10 лет (включительно) до 15
      //лет, премия составляет 25% от заработной платы.Если выслуга от 15 лет (включительно) до 20 лет,
      //премия составляет 35% от заработной платы.Если выслуга от 20 лет (включительно) до 25 лет,
      //премия составляет 45% от заработной платы.Если выслуга от 25 лет (включительно) и более, премия
      //составляет 50% от заработной платы.Результаты расчета, выведите на экран.
        static void Main(string[] args)
        {
            int Salary = 0, SeniorityLevel = 0, SalaryBonus = 0,SalaryFinal = 0;
            Console.Write("Введите свою зарплату в грн = ");
            Salary = int.Parse(Console.ReadLine());
            Console.Write("Введите выслугу лет в вашей компании = ");
            SeniorityLevel = int.Parse(Console.ReadLine());
            if (SeniorityLevel == 0)
            {
                Console.WriteLine("У вас нету бонуса по зарплате ");
            }
            else if (SeniorityLevel > 0 && SeniorityLevel <5)
            {
                SalaryBonus = (Salary * 10) / 100;
                SalaryFinal = Salary + SalaryBonus;
                Console.WriteLine("Вы получаете премию 10 % от зарплаты сумма бонуса - " + SalaryBonus + "грн");
                Console.WriteLine("Ваша итогая зарплата - " + SalaryFinal + "грн");
            }
            else if (SeniorityLevel >= 5 && SeniorityLevel < 10)
            {
                SalaryBonus = (Salary * 15) / 100;
                SalaryFinal = Salary + SalaryBonus;
                Console.WriteLine("Вы получаете премию 15 % от зарплаты сумма бонуса - " + SalaryBonus + "грн");
                Console.WriteLine("Ваша итогая зарплата - " + SalaryFinal + "грн");
            }
            else if (SeniorityLevel >= 10 && SeniorityLevel < 15)
            {
                SalaryBonus = (Salary * 25) / 100;
                SalaryFinal = Salary + SalaryBonus;
                Console.WriteLine("Вы получаете премию 25 % от зарплаты сумма бонуса - " + SalaryBonus + "грн");
                Console.WriteLine("Ваша итогая зарплата - " + SalaryFinal + "грн");
            }
            else if (SeniorityLevel >= 15 && SeniorityLevel < 20)
            {
                SalaryBonus = (Salary * 35) / 100;
                SalaryFinal = Salary + SalaryBonus;
                Console.WriteLine("Вы получаете премию 35 % от зарплаты сумма бонуса - " + SalaryBonus + "грн");
                Console.WriteLine("Ваша итогая зарплата - " + SalaryFinal + "грн");
            }
            else if (SeniorityLevel >= 20 && SeniorityLevel < 25)
            {
                SalaryBonus = (Salary * 45) / 100;
                SalaryFinal = Salary + SalaryBonus;
                Console.WriteLine("Вы получаете премию 45 % от зарплаты сумма бонуса - " + SalaryBonus + "грн");
                Console.WriteLine("Ваша итогая зарплата - " + SalaryFinal + "грн");
            }
            else if (SeniorityLevel >= 25)
            {
                SalaryBonus = (Salary * 35) / 100;
                SalaryFinal = Salary + SalaryBonus;
                Console.WriteLine("Вы получаете премию 50 % от зарплаты сумма бонуса - " + SalaryBonus + "грн");
                Console.WriteLine("Ваша итогая зарплата - " + SalaryFinal + "грн");
            }
        }
    }
}

