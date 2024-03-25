using System;
using Task1;

class Program
{
    static void Main()
    {
        // Создаем массив чисел, который хотим отсортировать.
        var numbers = new[] { 5, 3, 1, 4, 2 };

        // Вызываем метод sort.
        Utilities.Sort(null);

        // Выводим отсортированный массив на экран.
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }
    }
}
