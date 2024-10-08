﻿/*6. Составить алгоритм решения задачи: сколько можно купить
 * быков, коров и телят, платя за быка 10 руб., за корову — 5 руб., а
 * за теленка — 0,5 руб., если на 100 руб. надо купить 100 голов скота
 */

namespace ConsoleApp1.Tasks
{
    public static class Task2
    {
        public static void Run() {

        double Rubls;
        int numbersHeads;

        // Ввод данных
        while (true)
        {
            Console.Write("Введите количество рублей (X): ");
            string inputRubls = Console.ReadLine();

            if (double.TryParse(inputRubls, out Rubls) && Rubls >= 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите положительное число.");
            }
        }
        while (true)
        {
            Console.Write("Введите количество голов скота (Y): ");
            string inputNumbersHeads = Console.ReadLine();

            if (int.TryParse(inputNumbersHeads, out numbersHeads) && numbersHeads >= 0)
            {
                break;
            }
            else
            {
                Console.WriteLine("Некорректный ввод. Пожалуйста, введите положительное целое число.");
            }
        }
        
        // Цены на скот
        double priceBull = 10.0;
        double priceCow = 5.0;
        double priceCalf = 0.5;

        // Флаг, чтобы проверить, нашлось ли решение
        bool found = false;

        // Старый переработанный алгоритм с учетом того, что количество денег и голов может измениться
        for (int bulls = 0; bulls <= numbersHeads; bulls++)
        {
            for (int cows = 0; cows <= numbersHeads - bulls; cows++)
            {
                int calves = numbersHeads - bulls - cows;
                double totalCost = bulls * priceBull + cows * priceCow + calves * priceCalf;

                if (totalCost == Rubls && calves >= 0)
                {
                    Console.WriteLine($"Быков: {bulls}, Коров: {cows}, Телята: {calves}");
                    found = true;
                }
            }
        }

        if (!found)
        {
            Console.WriteLine("Решение не найдено.");
        }
        }
    }
}
