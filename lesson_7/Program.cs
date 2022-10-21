// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
/*
Console.Clear();


void InputMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-9, 10); ;
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
double[,] matrix = new double[n, m];
InputMatrix(matrix);
*/

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
/*

Console.Clear();


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-9, 10); ;
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);


Console.WriteLine("Введите индекс строки (счет с 0)");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите индекс столбца (счет с 0)");
int b = Convert.ToInt32(Console.ReadLine());
void FindIndexMatrix(int[,] matrix)
{
    if (a >= 0 && a < matrix.GetLength(0) && b >= 0 && b < matrix.GetLength(1))
    {
        Console.WriteLine("Элемент: " + matrix[a, b]);
    }
    else
    {
        Console.WriteLine("Позиции в массиве нет");
    }
}
FindIndexMatrix(matrix);
*/


//Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
/*

Console.Clear();


void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(-9, 10); ;
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
}

void XMatrix(int[,] matrix)
{
    double sumColumns = 0;
    double XColumns = 0;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sumColumns += matrix[i, j];
        }
        XColumns = sumColumns / matrix.GetLength(0);
        Console.WriteLine("Среднеарифметическое = " + XColumns);
        sumColumns = 0;
    }
}
Console.Write("Введите кол-во строк: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите кол-во столбцов: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[n, m];
InputMatrix(matrix);
XMatrix(matrix);
*/