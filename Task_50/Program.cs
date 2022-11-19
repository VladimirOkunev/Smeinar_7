// Напишите программу, которая на вход 
// принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, 
// что такого элемента нет.

int [,] NewArray(int rows, int columns)
{
    int [,] array = new int[rows, columns];
 
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            
            array[i, j] = new Random().Next(-100, 101);
          
        }

    }
    return array;
}

void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j],7} |");
            else Console.Write($"{array[i, j],7}");
        }
        Console.WriteLine(" ");
    }

}

void CheckArrayPosition(int [,] array, int rowNumber, int columnNumber)
{
    if(rowNumber <= array.GetLength(0)-1 && columnNumber <= array.GetLength(1)-1) 
    Console.Write($"Element of the array with position ({rowNumber}, {columnNumber}): {array[rowNumber, columnNumber]}");
    else Console.Write($"Position ({rowNumber}, {columnNumber}) is outside of the array");
}

Console.Clear();
int [,] arr = NewArray(5,6);
PrintArray(arr);
Console.WriteLine("Enter position of the array:");
Console.Write("Number of row: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Number of column: ");
int n = int.Parse(Console.ReadLine() ?? "0");

CheckArrayPosition(arr, m, n);