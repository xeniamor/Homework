﻿//Задача 1. Напишите программу, которая на вход принимает два числа
//и выдает, какое число большее, а какое меньшее.

/*
Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

if (a>b)
{
 Console.WriteLine($"Число {a} - большеe, а число {b} - меньшее");
}
else
{
 Console.WriteLine($"Число {b} - большеe, а число {a} - меньшее");
}
*/

//Задача 2.Напишите программу, которая принимает на вход
//три числа и выдаёт максимальное из этих чисел.

Console.WriteLine("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите третье число: ");
int c = Convert.ToInt32(Console.ReadLine());

int max = a;

if (b>max) max = b;
if (c>max) max = c;

Console.WriteLine("Максимальное число - " + max);
