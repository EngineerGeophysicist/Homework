using System;
using static System.Console;

Clear();

int[,,] array = GetArray(2, 2, 2, 10, 100);

PrintArray(array);



int[,,] GetArray(int m, int n, int t, int minValue, int maxValue)
{
    int[,,] result = new int[m, n,t];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            for (int g = 0; g < t; g++)
            {
                result[i, j, g] = new Random().Next(minValue, maxValue + 1);
            }
        }
    }
    return result;
}

void PrintArray(int[,,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
           for (int g = 0; g < 2; g++)
           { 
           Write($"{inArray[i,j,g] } ({i},{j},{g}) ");
           }
           WriteLine();
        }
        
    }
    WriteLine();
}


