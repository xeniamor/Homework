// Задача 1. Задайте двумерный массив. Напишите программу, которая упорядочит
// по убыванию элементы каждой строки двумерного массива.

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
