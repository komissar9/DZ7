// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество cтолбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите мин целое число в массиве: ");
int minRandom = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите макс целое число в массиве: ");
int maxRandom = Convert.ToInt32(Console.ReadLine());
double[,] array2D = GetMatrix(rows, columns, minRandom, maxRandom);

double [,] GetMatrix (int m, int n, int min, int max)
{
    double [,] matrix = new double [m, n];
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(min,max) + Math.Round(new Random().NextDouble(), 2);
        }
    }
    return matrix;
}
void PrintMatrix (double [,] matrix)
{
     for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i,j] + "\t");
        }
        Console.WriteLine();
    }

}
PrintMatrix(array2D);

// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет
// у меня эта задача просто продолжение предыдущей :)
Console.Write("Введите № строки (отсчет начинается с 0): ");
int rowsUser = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите № cтолбца (отсчет начинается с 0): ");
int columnsUser = Convert.ToInt32(Console.ReadLine());
if (rowsUser < rows & columnsUser < columns)
{
    Console.WriteLine(array2D[rowsUser, columnsUser]);
}
else
{
    Console.WriteLine("Такого элемента нет в массиве");
}

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце