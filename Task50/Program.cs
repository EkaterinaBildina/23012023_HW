// Задача 50. Напишите программу, 
// которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента 
// или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// (1,7) -> такого элемента в массиве нет



int[,] CreateMatrixRndInt(int rows, int columns, int min, int max)
{
    int[,] matrix = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rnd.Next(min, max + 1);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j < matrix.GetLength(1) - 1) Console.Write($"{matrix[i, j],5},");
            else Console.Write($"{matrix[i, j],5}  ");
        }
        Console.WriteLine("]");
    }
}

void PrintFoundElement(int[,] matrix, int numRow, int numColumn)
{
    if (numRow > matrix.GetLength(0) || numColumn > matrix.GetLength(1))
    {
        Console.WriteLine($"({numRow},{numColumn}) -> there is no such element in the matrix");
    }
    else Console.WriteLine($"Requested element  = {matrix[numRow, numColumn]}");
}

bool IsPositiveInputIndex(int indexRow, int indexColumn)
{
    return indexRow > 0 && indexColumn > 0;
}

int[,] array2D = CreateMatrixRndInt(3, 4, -10, 10);
PrintMatrix(array2D);

Console.WriteLine("");
Console.WriteLine("!!!Attantion: index in the matrix start with [0,0].");
Console.WriteLine("Please input index to display the desired number in the Matrix:");
Console.WriteLine("");

Console.Write("index1(row number):  ");
int index1 = Convert.ToInt32(Console.ReadLine());
Console.Write("index2(column number):  ");
int index2 = Convert.ToInt32(Console.ReadLine());

if (IsPositiveInputIndex(index1, index2))
{
    PrintFoundElement(array2D, index1, index2);
}
else Console.WriteLine("Negative index is error");