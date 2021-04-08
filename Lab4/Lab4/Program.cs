using System;
using System.Collections.Generic;

namespace Lab4
{
    class Program
    {
        static void Main(string[] args)
        {
            //test123
            var votesResult = new List<int[]>();
            string[] pets = { "Кошка", "Собака", "Рыбки", "Попугай", "Ящерка" };
            string[] voters = { "Мама", "Папа", "Дедушка", "Бабушка", "Брат", "Сестра" };

            //вводим начальные данные
            Console.WriteLine("Кол-во рассматриваемых животных (не более 5):");
            int altCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Кол-во голосующих:");
            int votersCount = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            //собираем данные по голосованию
            Console.WriteLine("Приоритеты голосующих");
            Console.WriteLine();
            for (int i = 0; i < altCount; i++)
            {
                Console.WriteLine($"Приоритеты для животного '{pets[i]}'");


                int[] result = new int[votersCount];

                for (int j = 0; j < votersCount; j++)
                {
                    if (j < voters.Length)
                        Console.WriteLine($"Введите приоритет голосующего '{voters[j]}' (от 1 до {votersCount})");
                    else
                        Console.WriteLine($"Введите приоритет голосующего 'Дальний родственник {j - voters.Length + 1}' (от 1 до {votersCount})"); 

                    result[j] = Convert.ToInt32(Console.ReadLine());


                }
                votesResult.Add(result);
                Console.WriteLine();
            }

            //вызываем методы для расчета победителя и вывод результатов
            Console.WriteLine("Относительно большинства");
            RelMajority relMajority = new RelMajority(votesResult);
            relMajority.CalculateResult();

            ModelKondorse modelKondorse = new ModelKondorse(votesResult);
            Console.WriteLine();

            Console.WriteLine("Явный победитель");
            modelKondorse.CalculateResultClearWinner();
            Console.WriteLine();

            Console.WriteLine("Правило Копленда");
            modelKondorse.CalculateResultKopland();
            Console.WriteLine();

            Console.WriteLine("Правило Симпсона");
            modelKondorse.CalculateResultSimpson();
            Console.WriteLine();

            Console.WriteLine("Модель Борда");
            ModelBorda modelBorda = new ModelBorda(votesResult);
            modelBorda.CalculateResult();
            Console.WriteLine();

            Console.ReadLine();

        }
    }
}
