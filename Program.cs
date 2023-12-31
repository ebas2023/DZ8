﻿/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

Console.WriteLine("Введите количество элементов двумерного массива m:");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество элементов двумерного массива n:");
int n = int.Parse(Console.ReadLine()!);

int[,] matrix = GetArray(m, n);
PrintArray(matrix);
Console.WriteLine();
int[,] itog = Vozrast(matrix);
PrintArray(itog);

int[,] GetArray(int m, int n)
{
    int[,] matrix = new int[m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }

    }
    return matrix;
}

void PrintArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"({matrix[i, j]})");
        }
        Console.WriteLine(" ");
    }

}

int[,] Vozrast(int[,] matrix)
{
    int max = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1) - 1; j++)
        {
            for (int a = 0; a < matrix.GetLength(1) - 1; a++)
            {
                if (matrix[i, a] < matrix[i, a + 1])
                {
                    max = matrix[i, a + 1];
                    matrix[i, a + 1] = matrix[i, a];
                    matrix[i, a] = max;
                }
            }

        }

    }
    return matrix;
}

