using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module13PZ
{
    class Program
    {
        static void Main()
        {
            List<int> numbers = new List<int> { 10, 5, 8, 15, 7, 20, 3, 25 };

            FindAndPrintSecondMax(numbers);

            RemoveOddNumbers(numbers);

            PrintElementsAboveAverage(numbers);

            Console.WriteLine("Удаления нечетных элементов:");
            foreach (var num in numbers)
            {
                Console.Write(num + " ");
            }
        }

        static void FindAndPrintSecondMax(List<int> numbers)
        {
            if (numbers.Count < 2)
            {
                Console.WriteLine("Недостаточно элементов в коллекции.");
                return;
            }

            int secondMax = numbers.OrderByDescending(x => x).Skip(1).First();

            int index = numbers.IndexOf(secondMax);
            Console.WriteLine($"Позиция второго максимального элемента: {index}, Значение: {secondMax}");
        }

        static void RemoveOddNumbers(List<int> numbers)
        {
            numbers.RemoveAll(x => x % 2 != 0);
        }

        static void PrintElementsAboveAverage(List<int> numbers)
        {
            if (numbers.Count == 0)
            {
                Console.WriteLine("Коллекция пуста.");
                return;
            }

            double average = numbers.Average();

            Console.WriteLine($"Элементы, значение которых больше среднего арифметического ({average}):");
            foreach (var num in numbers.Where(x => x > average))
            {
                Console.Write(num + " ");
            }
        }
    }
}
