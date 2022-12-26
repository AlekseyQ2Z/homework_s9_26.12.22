// Задайте значение N. Напишите программу, которая выведет все натуральные 
// числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int GetNaturalNumbers(int n)
{
    if (n == 1)
    {
        return 1;
    }
    else
    {
        Console.Write(n + " ");
        return PrintNaturalNumbers(n - 1);
    }

}

Console.WriteLine("Напишите натуральное число и я покажу все натуральные числа от него до 1");
int number = Convert.ToInt32(Console.ReadLine());
Console.Write(GetNaturalNumbers(number));