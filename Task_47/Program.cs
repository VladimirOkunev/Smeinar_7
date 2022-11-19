// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.

double[,] NewArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];
    double temporaryValue = 0; // used to generate floating point numbers
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            temporaryValue = new Random().NextDouble() * 100;
            array[i, j] = new Random().NextDouble() * 100 - temporaryValue;
            array[i, j] = Math.Round(array[i, j], 2);
        }

    }
    return array;
}

void PrintArray(double[,] array)
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

Console.Clear();

Console.WriteLine("Enter size of 2D array");
Console.Write("Numbers of rows: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Numbers of columns: ");
int n = int.Parse(Console.ReadLine() ?? "0");
Console.WriteLine("");
double[,] array = NewArray(m, n);
PrintArray(array);