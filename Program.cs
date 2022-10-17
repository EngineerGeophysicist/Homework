using System;
using static System.Console;

Clear();

int[,] array1 = GetArray(2, 2, 0, 10);
int[,] array2 = GetArray(2, 2, 0, 10);
PrintArray(array1);
PrintArray(array2);
ArrayMultiplication(array1,array2);


int[,] GetArray(int m, int n, int minValue, int maxValue)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(minValue, maxValue + 1);
        }
    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
           Write($"{inArray[i,j]} ");
        }
        WriteLine();
    }
    WriteLine();
}

void ArrayMultiplication (int[,] ar1,int[,] ar2)
{
    for (int i = 0; i < ar1.GetLength(0); i++)
    {
        for (int j = 0; j < ar1.GetLength(1); j++)
        {
           Write($"{ar1[i,j]*ar2[i,j]} ");
        }
        WriteLine();
    }
    WriteLine();
}