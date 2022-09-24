// Задача 19 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
/*
Console.Clear();
Console.Write("Введите пятизначное число: ");
string n = Convert.ToString(Console.ReadLine());
if (n [0] == n [4] && n [1] == n [3])
Console.Write("Полиндром");
else 
Console.Write("Не полиндром");
*/

// Задача 21 Напишите программу, которая принимает на вход 
//  координаты двух точек и находит расстояние между ними в 3D пространстве.
/*
Console.Clear();
Console.Write("Введите координату Х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Х2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double S = Math.Sqrt((x1 - x2)*(x1 - x2) + (y1 - y2)*(y1 - y2)+(z1 - z2));
Console.WriteLine((Math.Round(S, 2)));
*/

// Задача 23 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
/*
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
for (int i = 1; i <= n; i++)
if (i == n)
Console.Write(i * i * i);
else
Console.Write(i * i * i + ", ");
*/