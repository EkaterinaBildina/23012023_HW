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


bool IsPositiveInputIndex(int indexRow, int indexColumn)
{
    return indexRow > 0 && indexColumn > 0;
}


int PrintFoundElement(int[,] arr2D, int numRow, int numColumn)
{
    // for (int i = 0; i < arr2D.Length; i++)
    if (numRow > arr2D.GetLength(0)) Console.WriteLine($"{numRow} input error: out of matrix range");
    if (numColumn > arr2D.GetLength(1)) Console.WriteLine($"{numColumn} input error: out of matrix range");
    else Console.WriteLine($"{arr2D[numRow, numColumn]}");
}



int[,] array2D = CreateMatrixRndInt(3, 4, -10, 10);
// PrintMatrix(array2D);

Console.WriteLine("Attantion:  index in the matrix starting since [0,0]");
Console.WriteLine("Please input idexs to display the desired number in the Matrix:");

Console.WriteLine("index1(row number):  ");
int index1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("index2(column number):  ");
int index2 = Convert.ToInt32(Console.ReadLine());
// IsPositiveInputIndex(index1, index2);
//PrintFoundElement(array2D, index1, index2);

if (IsPositiveInputIndex(index1, index2))
{
    bool result = PrintFoundedElement(array2D, index1, index2);
    Console.WriteLine(result ? "Нет" : "Да");
}
else Console.WriteLine("Error of the index input");