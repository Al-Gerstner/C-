// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее
/*
Console.Clear();
Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (n > m)
Console.WriteLine("первое число больше второго");
else
Console.WriteLine("второе число больше первого");
*/

// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
Console.Clear();
Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int l = Convert.ToInt32(Console.ReadLine());
if (n > m & n > l)
Console.WriteLine("первое число больше");
else if (m > n & m > l)
Console.WriteLine("второе число больше");
else
Console.WriteLine("третье число больше");
*/

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным.
/*
Console.Clear();
Console.Write("Введите число: ");
int n = Convert.ToInt32(Console.ReadLine());
if (n % 2 == 0)
Console.WriteLine("число четное");
else
Console.WriteLine("число нечетное");
*/

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
/*
Console.Clear();
Console.Write("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
for (int i = 2; i <= N; i+=2)
Console.Write(i + " ");
*/