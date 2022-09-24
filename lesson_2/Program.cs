// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
//   и на выходе показывает вторую цифру этого числа.
/*
Console.Clear();
Console.Write("Введите трехзначное число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("вторая цифра числа: " + n / 10 % 10);
*/

// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
/*
Console.Clear();
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
string M = Convert.ToString(N);
if (M.Length > 2)
Console.WriteLine("третья цифра: " + M[2]);
else
Console.WriteLine("третьей цифры нет");
*/

// Задача 15: Напишите программу, которая принимает на вход цифру,
//   обозначающую день недели, и проверяет, является ли этот день выходным.
/*
Console.Clear();
Console.Write("Введите цифру дня недели: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n == 6 || n == 7) 
Console.WriteLine("Выходной день");
else if (n < 1 || n > 7) 
Console.WriteLine("Введите цифру от 1 до 7");
else Console.WriteLine("Будний день");
*/