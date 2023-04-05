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
/*
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
*/

//Задача 3.Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет,является ли этот день выходным.
/*
bool Weekend(int numday)
{
    if(numday >= 6 && numday <= 7) return true;
    else return false;
}

Console.WriteLine("Введите цифру, обозначающую день недели, чтобы узнать, является ли он выходным: ");
int numday = Convert.ToInt32(Console.ReadLine());

if(Weekend(numday) == true) 
Console.WriteLine("Да, день является выходным");
else 
Console.WriteLine("День не является выходным");
*/

