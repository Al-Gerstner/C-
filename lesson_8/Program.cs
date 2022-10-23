// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
/*
Console.Clear();
int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 9)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите число строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int n = Convert.ToInt32(Console.ReadLine());
void InvertMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            for (int k = 0; k < matrix.GetLength(1) - 1; k++)
            {
                if (matrix[i, k] < matrix[i, k + 1])
                {
                    int temp = matrix[i, k + 1];
                    matrix[i, k + 1] = matrix[i, k];
                    matrix[i, k] = temp;
                }
            }
        }
    }
}
int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();
InvertMatrix(matrix);
PrintMatrix(matrix);
*/

// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
/*
Console.Clear();
int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 10)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите число строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
Console.WriteLine();
int sumRow = 0;
int maxLine = 0;
int max = sumRow;
int temp = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        temp += matrix[i, j];
        sumRow = temp;
    }
    temp = 0;
    if (max < sumRow)
    {
        max = sumRow;
        maxLine = i + 1;
    }
    Console.WriteLine($"Сумма {i + 1} строки = {sumRow} ");
}
Console.WriteLine($"Максимальная строка {maxLine} с суммой = {max} ");
*/

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
/*
Console.Clear();
int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange = 0, int rightRange = 10)
{
    int[,] matrix = new int[rowsCount, columnsCount];
    Random rand = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange);
        }
    }
    return matrix;
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Введите число строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число столбцов");
int n = Convert.ToInt32(Console.ReadLine());
int[,] firstMatrix = FillMatrix(m, n);
int[,] secondMatrix = FillMatrix(m, n);
Console.WriteLine($"Первая матрица");
PrintMatrix(firstMatrix);
Console.WriteLine($"Вторая матрица");
PrintMatrix(secondMatrix);
Console.WriteLine($"Произведение  матриц");
int[,] multiMatrix = multiMatrix = new int[m, n];
for (int i = 0; i < multiMatrix.GetLength(0); i++)
{
    for (int j = 0; j < multiMatrix.GetLength(1); j++)
    {
        multiMatrix[i, j] = firstMatrix[i, j] * secondMatrix[i, j];
    };
}
PrintMatrix(multiMatrix);
*/

// Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
/*
Console.Clear();
void PrintMatrix (int[,,] matrix3D)
{
  for (int i = 0; i < matrix3D.GetLength(0); i++)
  {
    for (int j = 0; j < matrix3D.GetLength(1); j++)
    {
      for (int k = 0; k < matrix3D.GetLength(2); k++)
      {
        Console.Write( $" [{i},{j},{k}] = {matrix3D[i,j,k]}; ");
      }
      Console.WriteLine();
    }
    Console.WriteLine();
  }
}
void FillMatrix(int[,,] matrix3D)
{
  int[] temp = new int[matrix3D.GetLength(0) * matrix3D.GetLength(1) * matrix3D.GetLength(2)];
  int  number;
  for (int i = 0; i < temp.GetLength(0); i++)
  {
    temp[i] = new Random().Next(10, 100);
    number = temp[i];
    if (i >= 1)
    {
      for (int j = 0; j < i; j++)
      {
        while (temp[i] == temp[j])
        {
          temp[i] = new Random().Next(10, 100);
          j = 0;
          number = temp[i];
        }
          number = temp[i];
      }
    }
  }
  int count = 0; 
  for (int x = 0; x < matrix3D.GetLength(0); x++)
  {
    for (int y = 0; y < matrix3D.GetLength(1); y++)
    {
      for (int z = 0; z < matrix3D.GetLength(2); z++)
      {
        matrix3D[x, y, z] = temp[count];
        count++;
      }
    }
  }
}
Console.WriteLine("Введите число x");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число y");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число z");
int z = Convert.ToInt32(Console.ReadLine());
int[,,] matrix3D = new int[x, y, z];
FillMatrix(matrix3D);
PrintMatrix(matrix3D);
*/

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
/*
Console.Clear();
int n = 4;
int[,] matrix = new int[n, n];
int temp = 1;
int i = 0;
int j = 0;
while (temp <= matrix.GetLength(0) * matrix.GetLength(1))
{
  matrix[i, j] = temp;
  temp++;
  if (i <= j + 1 && i + j < matrix.GetLength(1) - 1)
    j++;
  else if (i < j && i + j >= matrix.GetLength(0) - 1)
    i++;
  else if (i >= j && i + j > matrix.GetLength(1) - 1)
    j--;
  else
    i--;
}
void FillMatrix (int[,] matrix)
{
  for (int i = 0; i < matrix.GetLength(0); i++)
  {
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
      if (matrix[i,j] / 10 <= 0)
      Console.Write($" {matrix[i,j]} ");

      else Console.Write($"{matrix[i,j]} ");
    }
    Console.WriteLine();
  }
}
FillMatrix(matrix);
*/