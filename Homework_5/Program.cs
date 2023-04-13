//Задача 1. Задайте массив заполненный случайными положительными трёхзначными числами.
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*
int[] CreateArrayPositiveThreeDigitRandom(int size)
{
   int[] array = new int[size];
   for (int i = 0; i < size; i++)
      array[i] = new Random().Next(100, 1000);
   return array;
}

void ShowArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
      Console.Write(array[i] + " ");
   Console.WriteLine();
}

int QuantityEvenNumbers(int[] array)
{
   int count = 0;
   for (int i = 0; i < array.Length; i++)
      if (array[i] % 2 == 0) count++;
   return count;
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] newArray = CreateArrayPositiveThreeDigitRandom(size);
ShowArray(newArray);
int result = QuantityEvenNumbers(newArray);
Console.WriteLine($"Количество четных чисел в массиве - {result}");
*/

//Задача 2.Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.

int[] CreateRandomArray(int size, int minValue, int maxValue)
{
   int[] array = new int[size];
   for (int i = 0; i < size; i++)
      array[i] = new Random().Next(minValue, maxValue + 1);
   return array;
}

void ShowArray(int[] array)
{
   for (int i = 0; i < array.Length; i++)
      Console.Write(array[i] + " ");
   Console.WriteLine();
}

int SumElementsOddPosition(int[] array)
{
   int sum = 0;
   for (int i = 1; i < array.Length; i += 2) sum += array[i];
   return sum;
}
Console.Write("Введите размер массива: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите минимальное значение: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите максимальное значение: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);
int result = SumElementsOddPosition(newArray);
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях - {result}");
