//Задача 1. Задайте двумерный массив размером m×n,
//заполненный случайными вещественными числами.

double[,] CreateRandom2dArray()
{
    Console.WriteLine("Введите корректное количество строк:");
    int rows = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите корректное количество столбцов:");
    int columns = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите минимальное значение:");
    double minVal = Convert.ToDouble(Console.ReadLine());
    Console.WriteLine("Введите максимальное значение:");
    double maxVal = Convert.ToDouble(Console.ReadLine());

    double[,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
            array[i, j] = Math.Round(new Random().Next(Convert.ToInt32(minVal), Convert.ToInt32(maxVal) + 1) + new Random().NextDouble(), 2);                                                
    return array;
}
void Show2dArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
}
Show2dArray(CreateRandom2dArray());
