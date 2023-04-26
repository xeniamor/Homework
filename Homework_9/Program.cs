// Задача 1.Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

void ShowNum(int num)
{
    Console.Write(num + " ");
    if(num > 1) ShowNum(num - 1);
}
Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

ShowNum(number);