using System.Drawing;
using System;
using System.Reflection.Metadata;

Console.WriteLine("Введите размер матрици: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Snake: ") ;
int[,] matrix = new int[n, n];

int start = 1;

for (int k = 1 - n; k <= n - 1; k++)
{
    for (int i = 0; i < n; i++)
    {
        int j = i - k;

        if (j < 0 || j >= n)
            continue;
        if ((k % 2) != 0)
        { 
           matrix[i, n - 1 - j] = start++;
        }
        else
        {
            matrix[n - 1 - j, i] = start++;
        } 

    }
    
}


for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
        
       Console.Write(matrix[i, j] + "|");
    Console.WriteLine();
}