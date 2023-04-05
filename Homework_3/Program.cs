//Задача 1. Напишите программу, которая принимает на вход пятизначное число
//и проверяет, является ли оно палиндромом(решение для универсального числа!)

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
