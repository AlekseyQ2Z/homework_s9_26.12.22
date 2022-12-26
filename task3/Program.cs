// Напишите программу вычисления функции Аккермана с 
// помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9 (?)
// m = 3, n = 2 -> A(m,n) = 29 (?)

int СalculateAckermanFunction(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return СalculateAckermanFunction(m - 1, 1);
    }
    else
    {
        return СalculateAckermanFunction(m - 1, СalculateAckermanFunction(m, n - 1));
    }
}

Console.WriteLine("Напишите два неотрицательных числа и я вычислю функцию Аккермана");
Console.WriteLine("Напишите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Напишите второе чичло: ");
int number2 = Convert.ToInt32(Console.ReadLine());
if (number1 < 0 || number2 < 0)
{
    Console.WriteLine("Error одно или оба числа отрицательные");
}
else
{
    Console.WriteLine(СalculateAckermanFunction(number1, number2));
}