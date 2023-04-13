//Задача 1. Пользователь вводит с клавиатуры M чисел.
//Посчитайте, сколько чисел больше 0 ввёл пользователь.

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
Console.Write($"{result} чисел из введенных больше 0.");

