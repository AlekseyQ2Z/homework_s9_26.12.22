// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N. Выполнить с помощью рекурсии.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int SumNaturalNumbers(int n1, int n2)
{
    if (n1 > n2)
    {
        if (n1 == n2)
        {
            return 0;
        }
        else
        {
            return n1 + SumNaturalNumbers(n1 - 1, n2);
        }
    }
    if (n1 < n2)
    {
        if (n2 == n1)
        {
            return 0;
        }
        else
        {
            return n2 + SumNaturalNumbers(n1, n2 - 1);
        }
    }
    else
    {
        return n1;
    }
}

Console.WriteLine("Введи два числа и я напишу тебе сумму всех натуральных чисел между ними");
Console.WriteLine("Введи первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введи второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 < 0 || number2 < 0)
{
    Console.WriteLine("Error - числа или число не натуральное -ые");
}
else
{
    Console.Write("Их сумма: " + SumNaturalNumbers(number1, number2));
}