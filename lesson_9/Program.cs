// Задача 66: Задайте значения M и N. 
// Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
/*
Console.Clear();
Console.WriteLine("Введите число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N большее чем M");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberM > numberN)
{
    Console.WriteLine("Число N не может быть меньше M");
}
else
{
    int sum = SumCountFromMToN(numberN, numberM);
    Console.WriteLine(sum);
}
int SumCountFromMToN(int n, int m)
{
    if (n == m) return 0;
    int sum = ((n + m)*(n - m + 1) / 2) - (m + n);
    return sum;
}
*/

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
/*
Console.Clear();
Console.WriteLine("Введите число M");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число N");
int numberN = Convert.ToInt32(Console.ReadLine());
if (numberM >= 0 && numberN >= 0)
{
    int sum = SumCountFromMToN(numberN, numberM);
    Console.WriteLine(sum);
}
else
{
    Console.WriteLine("Число M и N не могут быть отрицательными");
}
int SumCountFromMToN(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    if (m > 0 && n == 0)
    {
        return SumCountFromMToN(m - 1, 1);
    }
    else
    {
        return SumCountFromMToN(m - 1, SumCountFromMToN(m, n - 1)); // я запуталась тут
    }
}
*/

