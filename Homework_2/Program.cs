//Задача 1. Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.
/*
void SecondDigit(int num)
{
   int secondNum = num % 100 / 10;
   Console.WriteLine($"Вторая цифра введенного Вами числа {num} - это {secondNum}");
}

Console.WriteLine("Введите трехзначное число: ");
int num = Convert.ToInt32(Console.ReadLine());

SecondDigit(num);
*/

//Задача 2. Напишите программу, которая выводит третью цифру
//заданного числа или сообщает, что третьей цифры нет.

int ThirdDigit (int num)
{
   while (num >= 1000) num = num/10;
   return num % 10;
}

Console.WriteLine("Введите число, чтобы узнать его третью цифру: ");
int num = Convert.ToInt32(Console.ReadLine());

if(num < 100)
{
   Console.WriteLine("Вы ввели некорректное число, введите число которое больше или равно трехзначному числу");
}
else 
{  
Console.WriteLine($"Третья цифра введенного вами числа {num} - это ");
Console.WriteLine (ThirdDigit (num));
}
