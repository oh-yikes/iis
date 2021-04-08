using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lab4
{
    class ModelKondorse
    {
        string[] pets = { "Кошка", "Собака", "Рыбки", "Попугай", "Ящерка" };

        public List<int[]> votesResults;

        public ModelKondorse(List<int[]> votesResults)
        {
            this.votesResults = votesResults;
        }


        public void CalculateResultClearWinner()
        {
            int[] result = new int[votesResults.Count];

            for (int i = 0; i < votesResults.Count; i++)
            {
                for (int j = i + 1; j < votesResults.Count; j++)
                {
                    int iWins = 0;
                    int jWins = 0;
                    foreach (var vote in votesResults) //перебор списка приоритетов
                    {
                        if (Array.IndexOf(vote, i + 1) < Array.IndexOf(vote, j + 1)) //если альтернатива i лучше j
                            iWins++;
                        else if (Array.IndexOf(vote, i + 1) != Array.IndexOf(vote, j + 1)) //если альтернатива j лучше i
                            jWins++;
                    }

                    if (iWins > jWins) //если альтернативу i выбрало больше людей
                    {
                        result[i]++;
                        Console.WriteLine($"Альтернатива '{pets[i]}' ={iWins} > альтернатива '{pets[j]}' = {jWins}");
                    }
                    else if (iWins != jWins) //если альтернативу j выбрало больше людей
                    {
                        result[j]++;
                        Console.WriteLine($"Альтернатива '{pets[j]}' ={jWins} > альтернатива '{pets[i]}' = {iWins}");
                    }
                    j++;
                }
            }
            //подсчет результата
            var a = result.Max();
            var res = Array.IndexOf(result, a);
            var res2 = Array.LastIndexOf(result, a);
            if (res == res2)
                Console.WriteLine($"Альтернатива {pets[res]} выиграла");
            else
                Console.WriteLine($"Парадокс Кондорсе! Альтернативы {pets[res]} {pets[res2]} выиграли");

        }

        public void CalculateResultKopland()
        {
            int[] result = new int[votesResults.Count];

            for (int i = 0; i < votesResults.Count; i++)
            {
                for (int j = i + 1; j < votesResults.Count; j++)
                {
                    int iWins = 0;
                    int jWins = 0;
                    foreach (var vote in votesResults) //перебор списка приоритетов
                    {
                        if (Array.IndexOf(vote, i + 1) < Array.IndexOf(vote, j + 1)) //если альтернатива i лучше j
                            iWins++;
                        else if (Array.IndexOf(vote, i + 1) != Array.IndexOf(vote, j + 1)) //если альтернатива j лучше i
                            jWins++;
                    }
                    if (iWins > jWins) //если альтернативу i выбрало больше людей
                    {
                        result[i] += 1;
                        result[j] -= 1;
                        Console.WriteLine($"Альтернатива '{pets[i]}' = {iWins} итого {result[i]}> альтернатива '{pets[j]}' = {jWins} итого {result[j]}");
                    }
                    else if (iWins != jWins) //если альтернативу j выбрало больше людей
                    {
                        result[j] += 1;
                        result[i] -= 1;
                        Console.WriteLine($"Альтернатива '{pets[j]}' = {jWins} итого {result[j]} > альтернатива '{pets[i]}' = {iWins} итого {result[i]}");
                    }
                    else //если за альтернативу k равносильна i
                        Console.WriteLine($"Альтернатива '{pets[j]}' = {jWins} итого {result[j]} = альтернатива '{pets[i]}' = {iWins} итого {result[i]}");
                }
            }
            //подсчет результата
            var a = result.Max();
            var res = Array.IndexOf(result, a);
            var res2 = Array.LastIndexOf(result, a);
            if (res == res2)
                Console.WriteLine($"Альтернатива {pets[res]} выиграла");
            else
                Console.WriteLine($"Парадокс Кондорсе! Альтернативы {pets[res]} {pets[res2]} выиграли");

        }

        public void CalculateResultSimpson()
        {
            List<int> mins = new List<int>();
            for (int i = 0; i < votesResults.Count; i++)
            {
                List<int> rate = new List<int>();
                for (int j = 0; j < votesResults[0].Length; j++)
                {
                    int iWins = 0;
                    int jWins = 0;

                    if (i != j)
                    {
                        foreach (var vote in votesResults) //перебор списка приоритетов
                        {
                            if (Array.IndexOf(vote, i + 1) < Array.IndexOf(vote, j + 1)) //если альтернатива i лучше j
                                iWins++;
                            else if (Array.IndexOf(vote, i + 1) != Array.IndexOf(vote, j + 1)) //если альтернатива j лучше i
                                jWins++;
                        }
                        rate.Add(iWins); //создаем оценочный лист для сравнения i-ой альтернативы с остальными
                    }
                }
                if (rate.Count != 0)
                {
                    int m = rate.Min(); //ищем минимумы
                    mins.Add(m);
                }
            }
            int itog = mins.IndexOf(mins.Max()) + 1; // находим максимум в списке минимумов
            Console.WriteLine("Выигрывает альтернатива " + pets[itog] + " с результатом " + mins.Max());
        }

    }
}
