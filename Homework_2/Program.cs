//Задача 1. Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.

void SecondDigit(int num)
{
   int secondNum = num % 100 / 10;
   Console.WriteLine($"Вторая цифра введенного Вами числа {num} - это {secondNum}");
}

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

SecondDigit(num);
