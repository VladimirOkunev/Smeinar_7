// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов 
// в каждом столбце.

int[,] NewArray(int rows, int columns)
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
        Console.SetCursorPosition(28, i);
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (j < array.GetLength(1) - 1) Console.Write($"{array[i, j], 7} |");
            else Console.Write($"{array[i, j],7}");
        }
        Console.WriteLine(" ");
    }

}

void AverageInColumn(int[,] array)
{
    double sum = 0;
    Console.Write("Average of the each column: ");
    for (int i = 0; i < array.GetLength(1); i++)
    {
        for (int j = 0; j < array.GetLength(0); j++)
        {
            sum += array[j, i];
        }
        if (i < array.GetLength(1) - 1) Console.Write($"{sum / array.GetLength(0), 7} |");
        else Console.Write($"{sum / array.GetLength(0), 7}");
        sum = 0;
    }

}

Console.Clear();
int[,] arr = NewArray(5, 6);
PrintArray(arr);
Console.WriteLine("");
AverageInColumn(arr);
