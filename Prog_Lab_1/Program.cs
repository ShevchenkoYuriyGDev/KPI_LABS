using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;

namespace Prog_Lab_1
{
    internal class Program
    {
        static void ExerciseOne()
        {
            Console.WriteLine("Exercise 1");
            List<int> list = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("\n" + "First list");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(list[i] + "\t");
            }

            int minIndex = 0;
            int maxIndex = 0;
            int minValue = list[0];
            int maxValue = list[0];

            for (int i = 1; i < list.Count; i++)
            {
                if (list[i] < minValue)
                {
                    minIndex = i;
                    minValue = list[i];
                }
                else if (list[i] > maxValue)
                {
                    maxIndex = i;
                    maxValue = list[i];
                }
            }

            list[minIndex] = maxValue;
            list[maxIndex] = minValue;
            Console.WriteLine("\n" + "Edited list");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(list[i] + "\t");
            }
            Console.WriteLine("\n"+"--------------------------------------------------------------------------------------------------");
        }
        static void ExerciseTwo()
        {
            Console.WriteLine("Exercise 2");
            var People = new Dictionary<string, int>
            {
                {"A", 1},
                {"B", 3},
                {"C", 5},
                {"D", 7},
                {"E", 9},
                {"F", 2},
                {"G", 4},
                {"H", 6},
                {"I", 8},
                {"J", 0},
            };
            var sortedKeys = People.OrderByDescending(x => x.Value).Select(x => x.Key);
            foreach (var key in sortedKeys)
            {
                Console.WriteLine($"{key} - {People[key]}"); // Интерполяция строк
            }
            Console.WriteLine("\n"+"--------------------------------------------------------------------------------------------------");
        }
        static void ExerciseThree() 
        {
            Console.WriteLine("Exersice 3");
            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };
            var Nums1 = Numbers.Where(s => s % 2 == 1).Select(s => s.ToString()).OrderBy(s => s);
            var Nums2 = Numbers.Where(s => s % 2 == 1).Select(s => s.ToString()).OrderByDescending(s => s);
            foreach (var s in Nums1)
            {
                Console.Write(s + "\t");
            }
            Console.WriteLine("\n");
            foreach (var s in Nums2)
            {
                Console.Write(s + "\t");
            }
            Console.WriteLine("\n" + "--------------------------------------------------------------------------------------------------");
        }
        static void Main(string[] agrs)
        {
            ExerciseOne();
            ExerciseTwo();
            ExerciseThree();
            Console.ReadLine();
        }
    }
}