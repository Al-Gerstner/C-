/* Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
0, 7, 8, -2, -2 -> 2
1, -7, 567, 89, 223-> 3*/

Console.Clear();
Console.Write("Введите кол-во элементов массива: ");
int M = Convert.ToInt32(Console.ReadLine());
int[] array = new int[M];
Console.WriteLine("Введите числа: ");
int arr = Convert.ToInt32(Console.ReadLine());
int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i] > 0)
    {
        count++;
    }
}
Console.WriteLine("Кол-во элементов > 0: " + count);





/* Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, 
заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)*/
/*
Console.Clear();
Console.Write("Введите первое число: ");
int b1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int k1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int b2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите третье число: ");
int k2 = Convert.ToInt32(Console.ReadLine());
*/