//Задача 1. Задайте двумерный массив размером m×n,
//заполненный случайными вещественными числами.
/*
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
double[,] myArray = CreateRandom2dArray();
Show2dArray (myArray);
*/

//Задача 2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.

/*
int[,] CreateRandom2dArray()
{
   Console.WriteLine("Введите корректное количество строк:");
   int rows = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Введите корректное количество столбцов:");
   int columns = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Введите минимальное значение:");
   int min = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Введите максимальное значение:");
   int max = Convert.ToInt32(Console.ReadLine());

   int[,] array = new int[rows, columns];

   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         array[i, j] = new Random().Next(min, max + 1);
      }
   }
   return array;
}

void Show2dArray(int[,] array)

{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
         Console.Write(array[i, j] + " ");
      Console.WriteLine();
   }
   Console.WriteLine();
}

void CheckElementValue(int[,] array, int indexRow, int indexColumn)
{
   if (indexRow >= 0 && indexRow <= array.GetLength(0) - 1 && indexColumn >= 0 && indexColumn <= array.GetLength(1) - 1)
      Console.Write($"Элемент с позицией в строке {indexRow} и столбце {indexColumn} имеет значение: {array[indexRow, indexColumn]}");
   else
      Console.Write($"Такого элемента не существует!");
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);

Console.Write("Введите номер строки, в которой находится искомый элемент: ");
int indexRow = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Введите номер столбца, в котором находится искомый элемент: ");
int indexColumn = Convert.ToInt32(Console.ReadLine()) - 1;

CheckElementValue(myArray, indexRow, indexColumn);
*/

//Задача 3. Задайте двумерный массив из целых чисел.
//Найдите среднее арифметическое элементов в каждом столбце.
/*
int[,] CreateRandom2dArray()
{
   Console.WriteLine("Введите корректное количество строк:");
   int rows = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Введите корректное количество столбцов:");
   int columns = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Введите минимальное значение:");
   int min = Convert.ToInt32(Console.ReadLine());
   Console.WriteLine("Введите максимальное значение:");
   int max = Convert.ToInt32(Console.ReadLine());

   int[,] array = new int[rows, columns];

   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         array[i, j] = new Random().Next(min, max + 1);
      }
   }
   return array;
}

void Show2dArray(int[,] array)

{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
         Console.Write(array[i, j] + " ");
      Console.WriteLine();
   }
   Console.WriteLine();
}

double[] AverageElementsColumns(int[,] array)
{
   double[] arrayAverage = new double[array.GetLength(1)];
   for (int j = 0; j < array.GetLength(1); j++)
   {
      for (int i = 0; i < array.GetLength(0); i++)
      {
         arrayAverage[j] += array[i, j];
      }
      arrayAverage[j] = Math.Round((arrayAverage[j] / array.GetLength(0)), 2);
      Console.Write(arrayAverage[j] + " ");
   }
   return arrayAverage;
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
Console.WriteLine($"Среднее арифметическое элементов каждого столбца равняется: ");
AverageElementsColumns(myArray);
*/
