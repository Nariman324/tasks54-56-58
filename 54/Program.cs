// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.Write("Computer selected the number of lines... ");
int lines = new Random().Next(5, 10);
Console.WriteLine(" ");
Console.Write("Computer selected the number of rows... ");
int rows = new Random().Next(5, 10);
Console.WriteLine(" ");

Console.Write("Computer created an array... ");
Console.WriteLine(" ");


int[,] CreateTwoDimArray(int lines, int rows)
{
    int[,] matrix = new int[lines, rows];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
        }
        
    }
    return matrix;
}
void PrintTwoDimArray(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " ");
        }
        Console.WriteLine(" ");
    }
}

int[,] matrix = new int[lines, rows];
matrix = CreateTwoDimArray(lines, rows);

int[,] AscendOrder(int[,] matrix, int line, int finalLine)
{

    int i = line;
    int max = matrix[i, 0];
    int temp;
    int j = 0;
    int k = 0;
    while (j < rows)
    {
        max = matrix[i, j];
        int p = j + 1;

        while (p < rows)
        {
            if (matrix[i, p] > max)
            {
                max = matrix[i, p];
                k = p;
            }
            p++;
        }
        if (j != rows-1 && matrix[i, j] < max)
        {
            temp = matrix[i, k];
            matrix[i, k] = matrix[i, j];
            matrix[i, j] = temp;
        }

        j++;
    }
    if (line<finalLine)
    {
        line++;
        return AscendOrder(matrix, line, finalLine);
    }
    else return matrix;   
}


Console.Write("Computer prints the array... ");
Console.WriteLine(" ");
Console.WriteLine(" ");
PrintTwoDimArray(matrix);
Console.WriteLine(" ");
Console.Write("Computer sorts in ascending order  lines in the array... ");
Console.WriteLine(" ");
Console.Write("The computer prints the modified array... ");
Console.WriteLine(" ");
Console.WriteLine(" ");
PrintTwoDimArray(AscendOrder(matrix, 0, matrix.GetLength(0)-1));
Console.WriteLine(" ");