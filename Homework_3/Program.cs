//Задача 1. Напишите программу, которая принимает на вход пятизначное число
//и проверяет, является ли оно палиндромом(решение для универсального числа!)
/*
bool Palindrome(int num)
 {
      int num1 = num;
      int reversNum = 0;
        
     while(num1 > 0)
     {
         int lastDigit = num1 % 10;
         reversNum = reversNum * 10 + lastDigit;
         num1 = num1 / 10;
     }

     if(num == reversNum) return true;
     else return false;
}

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());

if(Palindrome(num) == true)
Console.WriteLine("Число является палиндромом");
else 
Console.WriteLine("Число не является палиндромом");
*/

//Задача 2. Напишите программу, которая принимает на вход координаты двух точек
//и находит расстояние между ними в 3D пространстве.
/*
double Length(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2));
}
Console.Write("Введите первую координату х для точки А: ");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первую координату у для точки А: ");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите первую координату z для точки А: ");
int z1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.Write("Введите вторую координату х для точки В: ");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую координату y для точки В: ");
int y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите вторую координату z для точки В: ");
int z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine();

Console.WriteLine($"Расстояние между точками А и В равно {Math.Round(Length(x1, y1, z1, x2, y2, z2), 2)}");
*/

//Задача 3.Напишите программу, которая принимает на вход число (N)
//и выдаёт таблицу кубов чисел от 1 до N.

void Cube (int n)
{
   for (int i = 1; i <= n; i++)
   {
      Console.WriteLine($"{i} - {Math.Pow(i, 3)}");
   }
}

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());

Cube(n);