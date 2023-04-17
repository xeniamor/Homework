//Задача 1. Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
/*
int PositiveNumbers(int[] array)
{
   int total = 0;

   for (int i = 0; i < array.Length; i++)
   {
      if (array[i] > 0)
         total = total + 1;
   }
   return total;
}

Console.Write("Укажите количество чисел, которое Вы хотите ввести: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] array = new int[n];
for (int i = 0; i < n; i++)
{
   Console.Write($"Введите {i + 1}-е число: ");
   array[i] = Convert.ToInt32(Console.ReadLine());
}


int result = PositiveNumbers(array);
Console.Write($"{result} чисел из введенных больше 0");
*/

//Задача 2. Напишите программу, которая найдёт точку пересечения двух прямых заданных уравнениями
//y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double IntersectionPoint(double b1, double k1, double b2, double k2)
{
    double x = (b2 - b1) / (k1 - k2);
    return x;
}
Console.Write("Введите координату k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());

Console.Write("Введите координату k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите координату b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());

if (k1 == k2 && b1 == b2)
    Console.WriteLine("Данные прямые совпадают. Точки пересечения нет.");
else
{
    if (k1 == k2)
        Console.WriteLine("Данные прямые параллельны. Точки пересечения нет.");
    else
    {
        double x = IntersectionPoint(b1, k1, b2, k2);
        Console.WriteLine($"Точка пересечения заданных прямых - х = {x}, y = {(k1 * x + b1)} ");
    }
}
