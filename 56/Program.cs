// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


int[,] CreateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i, j] = new Random().Next(0, 11);
        }
    }
    return array;
}
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0}	", array[i, j]);
        }
        Console.WriteLine(" ");
    }
}

Console.Write("Enter the number of rows...");
int rows = int.Parse(Console.ReadLine()!);
Console.Write("Enter the number of columns..");
int columns = int.Parse(Console.ReadLine()!);
Console.WriteLine(" ");
int[,] array = new int[rows, columns];
array = CreateArray(rows, columns);
Console.WriteLine(" ");
PrintArray(array);
Console.WriteLine(" ");

void SearchForMinSumRowNumber(int[,] array)
{
    int minSum = 0; //переменная для хранения наименьшей суммы  элементов в строке
    int numberOfMinSumRow= 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sumOfElementsInRow = 0;

        for (int j = 0; j < array.GetLength(1); j++)
        {
            sumOfElementsInRow += array[i, j]; // считаем сумму элементов в каждой строке       
        }
        if (i == 0) minSum = sumOfElementsInRow;
        else
        {
            if (sumOfElementsInRow < minSum)
            {
                minSum = sumOfElementsInRow;
                numberOfMinSumRow = i; 
            }
        }

    }
    Console.WriteLine("The number of row with minimal sum of elements in row is " + numberOfMinSumRow);
}

 SearchForMinSumRowNumber(array);