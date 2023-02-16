using System;

namespace _2
{
    class Program
    {
     //Используя Visual Studio, создайте проект по шаблону Console Application.
     //Напишите программу, которая будет рассчитывать процент скидки в зависимости от количества
     //купленного товара.Если куплено больше 3 единиц товара, тогда скидка должна быть 10 процентов
     //от общей суммы, если же количество больше 3 и меньше 7, то 20процентов от общей суммы, иначе,
     //если больше 7 то 25 процентов от общей суммы. Цену товара и купленное количество товара
     //пользователь должен задавать вводом с консоли.
        static void Main(string[] args)
        {
            int DiscountPercentage = 0, PurchasedItem = 0, ItemAmount = 0, FinalAmount = 0, PriceAfterDiscount = 0;
            Console.Write("Введите количество товара которое вы купили = ");
            PurchasedItem = int.Parse(Console.ReadLine());
            Console.Write("Введите сумму товара на которую вы купили = ");
            ItemAmount = int.Parse(Console.ReadLine());

            if (PurchasedItem > 0 && PurchasedItem <= 3)
            {
                DiscountPercentage = 10;
                PriceAfterDiscount = (ItemAmount * DiscountPercentage) / 100;
                FinalAmount = ItemAmount - PriceAfterDiscount;
                Console.Write("Вваша скидка = "+DiscountPercentage + "%" + "\tФинальная цена вашего товара = " + FinalAmount);
                
            }
            else if (PurchasedItem > 3 && PurchasedItem <=7)
            {
                DiscountPercentage = 20;
                PriceAfterDiscount = (ItemAmount * DiscountPercentage) / 100;
                FinalAmount = ItemAmount - PriceAfterDiscount;
                Console.Write("Вваша скидка = " + DiscountPercentage + "%" + "\tФинальная цена вашего товара = " + FinalAmount);
            }
            else if (PurchasedItem > 7)
            {
                DiscountPercentage = 25;
                PriceAfterDiscount = (ItemAmount * DiscountPercentage) / 100;
                FinalAmount = ItemAmount - PriceAfterDiscount;
                Console.Write("Вваша скидка = " + DiscountPercentage + "%" + "\tФинальная цена вашего товара = " + FinalAmount);
            }
        }
    }
}
