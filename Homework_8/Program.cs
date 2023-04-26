// Задача 1. Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.
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

void SortArray(int[,] array)
{
   for (int i = 0; i < array.GetLength(0); i++)
   {
      for (int j = 0; j < array.GetLength(1); j++)
      {
         for (int k = 0; k < array.GetLength(1) - 1; k++)
         {
            if (array[i, k] < array[i, k + 1])
            {
               int temp = array[i, k + 1];
               array[i, k + 1] = array[i, k];
               array[i, k] = temp;
            }
         }
      }
   }
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
SortArray(myArray);
Show2dArray(myArray);
*/

// Задача 2. Задайте прямоугольный двумерный массив. Напишите программу,
// которая будет находить строку с наименьшей суммой элементов.
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

void RowMinSum(int[,] array)
{
   int minRow = 0;
   for (int i = 0; i < array.GetLength(1); i++)
   {
      minRow += array[0, i];
   }

   int minSumRow = 0;
   for (int i = 0; i < array.GetLength(0); i++)
   {
      int sumRow = 0;
      for (int j = 0; j < array.GetLength(1); j++) sumRow += array[i, j];
      if (sumRow < minRow)
      {
         minRow = sumRow;
         minSumRow = i;
      }
      sumRow = 0;
   }
   Console.Write($"Cтрока c минимальной суммой элементов - {minSumRow + 1}");
}

int[,] myArray = CreateRandom2dArray();
Show2dArray(myArray);
RowMinSum(myArray);
*/
//  Задача 3.Задайте две матрицы. Напишите программу, 
//  которая будет находить произведение двух матриц.
/*
int[,] CreateRandom2dArray(int rows, int colums, int minValue, int maxValue)
{
    int[,] array = new int[rows, colums];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < colums; j++)
        {
            array[i, j] = new Random().Next(minValue, maxValue + 1);

        }
    }
    return array;
}
void Show2dArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int[,] MultiplicationMatrix(int[,] array1, int[,] array2)
{
    int[,] array = new int[array1.GetLength(0), array2.GetLength(1)];
    for (int k = 0; k < array1.GetLength(1); k++)
    {
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                array[i, j] += array1[i, k] * array2[k, j];
            }
        }
    }
    return array;
}
Console.Write("Введите корректное количество строк первой матрицы: ");
int rows1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите корректное количество столбцов первой матрицы: ");
int columns1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение первой матрицы: ");
int minValue1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение первой матрицы: ");
int maxValue1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите корректное количество строк второй матрицы: ");
int rows2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите корректное количество столбцов второй матрицы: ");
int columns2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение второй матрицы: ");
int minValue2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение второй матрицы: ");
int maxValue2 = Convert.ToInt32(Console.ReadLine());

while (columns1 != rows2)
{
    Console.WriteLine("Некорректно введенные данные! Матрицы не могут быть перемножены!");
    Console.WriteLine("Количество столбцов первой матрицы, должно быть равно количеству строк второй матрицы!");
    Console.Write("Введите корректное количество столбцов первой матрицы: ");
    columns1 = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите корректное количество строк второй матрицы: ");
    rows2 = Convert.ToInt32(Console.ReadLine());
}

int[,] Matrix1 = CreateRandom2dArray(rows1, columns1, minValue1, maxValue1);
int[,] Matrix2 = CreateRandom2dArray(rows2, columns2, minValue2, maxValue2);
int[,] MatrixResult = MultiplicationMatrix(Matrix1, Matrix2);


Show2dArray(Matrix1);
Show2dArray(Matrix2);
Show2dArray(MatrixResult);
*/

// Задача 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] CreateRandom3dArray()
{
    Console.Write("Введите кол-во элементов по X: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кол-во элементов по Y: ");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите кол-во элементов по Z: ");
    int z = Convert.ToInt32(Console.ReadLine());
       
    int[,,] array = new int[x, y, z];

    for(int i = 0; i < array.GetLength(0); i++)
        for(int j = 0; j < array.GetLength(1); j++)
            for(int k = 0; k < array.GetLength(2); k++)  
                array[i,j,k] = new Random().Next(10, 100);
    return array;
}

void Show3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k}) ");
            }
        }
    }
}

int[,,] myArray = CreateRandom3dArray();
Show3dArray(myArray);
