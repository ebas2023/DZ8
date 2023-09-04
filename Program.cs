/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;

Console.WriteLine("Введите количество элементов двумерного массива m:");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество элементов двумерного массива n:");
int n = int.Parse(Console.ReadLine()!);

int[,] matrix = GetArray(m, n);

PrintArray(matrix);
Console.WriteLine();

PrintArray2(matrix);


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

void PrintArray2(int[,] matrix)

{
    int Min = 0;
    int K = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        int S = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            S = S + matrix[i, j];
        }
        if (i == 0)
        {
            Min = S;
        }
        if (S <= Min)
        {
            Min = S;
            K = i + 1;
        }

    }
    Console.Write($"Номер строки с наименьшей суммой эдементов={K}");
}