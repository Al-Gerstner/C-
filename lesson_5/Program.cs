// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
/*
Console.Clear();
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(100, 1000);
}
int count(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
            count ++;
    }

    return count;
}
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine($"колличество четных чисел равно {count(array)}");
*/


// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
/*
Console.Clear();
void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(1, 10);
}
int Index(int[] array)
{
    int Index = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array [i] % 2 != 0)
            Index += array [i];
    }
    return Index;
}
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
InputArray(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine($"сумма элементов нечетных позиций равна {Index(array)}");
*/

// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементом массива.
/*
Console.Clear();
void Array(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = new Random().Next(0, 100);
}
int min(int[] array)
{
    int mini = 100;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < mini)
            mini = array[i];
    }
    return mini;
}
int max(int[] array)
{
    int maxi = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > maxi)
            maxi = array[i];
    }
    return maxi;
}
Console.Write("Введите кол-во элементов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
Array(array);
Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine($"разница: {max(array) - min(array)}");
*/