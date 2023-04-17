// Напишите цикл, который принимает на вход два числа (A и B)
//и возводит число A в натуральную степень B.
/*
double NumDegree(double a, int b)
{
   double result = 1;
   for (int i = 1; i <= b; i += 1)
      result = result * a;
   return result;
}
Console.Write("Введи число а, которое будем возводить в степень: ");
double a = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите натуральное число b, которое укажет на степень, в которую необходимо возвести число а: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.Write($"Число {a} в степени {b} равняется - {NumDegree(a, b)}");
*/

//Задача 2. Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
/*
int SummDigit(int num)
{
   int num1 = num;
   int sumDigit = 0;
   
    while(num1 > 0)
   {
        int lastDigit = num1 % 10;
        sumDigit = sumDigit + lastDigit;
        num1 = num1 / 10;
   }
   return sumDigit;
}
Console.Write("Введите целое число: ");
int a = Convert.ToInt32(Console.ReadLine());
int result = SummDigit(a);
Console.WriteLine($"Сумма цифр введенного числа {a} равняется - {result}");
*/



