//  Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
/*
Console.Clear();
Console.Write("Введите первое число (A): ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число (B): ");
int B = Convert.ToInt32(Console.ReadLine());
int result = A;
for (int i = 1; i < B; i++)
{
    result = result * A;
}
Console.WriteLine("A в степени B = " + result);
*/

// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
int m = 0;
while (n > 0)
{
int x = n % 10;
n = n / 10;
m = m + x;
}
Console.WriteLine("сумма цифр числа: " + m);
*/     
// Программа считает только в положительных числах.
// Подозреваю, что нужно прописать команду которая будет считать не обращая внимания на знак, но не знаю как)

// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
/*
Console.Clear();
int[] array = new int[8];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
}
Console.WriteLine("[" + string.Join(", ", array) + "]");
*/