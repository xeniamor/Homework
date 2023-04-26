// Задача 1.Задайте значение N. Напишите программу,
// которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.
/*
void ShowNum(int num)
{
    Console.Write(num + " ");
    if(num > 1) ShowNum(num - 1);
}
Console.Write("Введите число N: ");
int number = Convert.ToInt32(Console.ReadLine());

ShowNum(number);
*/

// Задача 2. Задайте значения M и N. Напишите программу,
// которая найдёт сумму натуральных элементов в промежутке от M до N.

 int SumNaturalElements(int m, int n)
{
    if(m == n) return m;
    else return SumNaturalElements(m + 1, n) + m;    
}

Console.Write("Введите первое число: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int n = Convert.ToInt32(Console.ReadLine());

int result = SumNaturalElements(m, n);
Console.Write($"Сумма натуральных элементов между числами {m} и {n} равняется - {result}");
