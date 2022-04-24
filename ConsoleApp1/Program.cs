using System;
using System.Threading;

namespace appi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"Задача:
Дан массив целых чисел из 30 элементов.
Найдите все локальные максимумы и вывести их. (Элемент является локальным максимумом, если он не имеет соседей, больших, чем он сам)

Крайние элементы являются локальными максимумами если не имеют соседа большего, чем они сами.

Программа должна работать с массивом любого размера.

Массив всех локальных максимумов не нужен.");
            Console.WriteLine();
            Random rand = new Random();
            byte numberOfColumns = 30;
            byte[] array = new byte[numberOfColumns];
            Console.WriteLine($"Колличество элементов = {array.Length}");
            for (byte i = 0; i < array.Length; i++)
            {
                array[i] = (byte)rand.Next(255);
                Console.Write($"{array[i]} ");
            }
            if (array[0] < array[1])
            {
                Console.WriteLine(array[0]);
            }
            for (byte i = 1; i < numberOfColumns - 1; i++)
            {
                if (array[i - 1] < array[i] && array[i + 1] < array[i])
                {
                    Console.WriteLine(array[i]);
                }
            }
            if (array[array.Length - 1] > array[array.Length - 2])
            {
                Console.WriteLine(array[array.Length - 1]);
            }
        }
    }
}