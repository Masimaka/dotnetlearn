﻿// See https://aka.ms/new-console-template for more information
// ExploreIf();
// loops();

void ExploreIf()
{
    int a = 5;
    int b = 3;
    if (a + b > 10)
    {
        Console.WriteLine("The answer is greater than 10");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10");
    }

    int c = 4;
    if ((a + b + c > 10) && (a > b))
    {
        Console.WriteLine("The answer is greater than 10");
        Console.WriteLine("And the first number is greater than the second");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10");
        Console.WriteLine("Or the first number is not greater than the second");
    }

    if ((a + b + c > 10) || (a > b))
    {
        Console.WriteLine("The answer is greater than 10");
        Console.WriteLine("Or the first number is greater than the second");
    }
    else
    {
        Console.WriteLine("The answer is not greater than 10");
        Console.WriteLine("And the first number is not greater than the second");
    }
}


// while do
void loops()
{
    int counter = 0;
    while (counter < 10)
    {
        Console.WriteLine($"Hello World! The counter is {counter}");
        counter++;
    }

    // do while
    int counter2 = 0;
    do
    {
        Console.WriteLine($"Hello World! The counter2 is {counter2}");
        counter2++;
    } while (counter2 < 10);

    // for

    for (int index = 0; index <= 10; index++)
    {
        Console.WriteLine($"Hello World! The index is {index}");
    }

    for (int row = 1; row < 11; row++)
    {
        for (char column = 'a'; column < 'k'; column++)
        {
            Console.WriteLine($"The cell is ({row}, {column})");
        }
    }
}
// попытайтесь написать код C# для поиска суммы всех целых чисел от 1 до 20, которые делятся на 3. 
int sum = 0;
for (int i = 1; i < 21; i++)
{
    // Console.WriteLine($"index is {i}");
    if (i % 3 == 0)
    {
        // Console.WriteLine($"{i} % 3 = 0 {i}");
        sum = sum + i;
    }
    else
    {
        // Console.WriteLine($"{i} % 3 != 0 ");
    }
}
Console.WriteLine($"summa must be 63 -> {sum}");
