// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// int a = int.Parse(Console.ReadLine());
// int b = int.Parse(Console.ReadLine());

// int result = Pow(a, b);

// Console.WriteLine($"Результат возведения {a} в степень {b} = {result}");


//   static int Pow(int a, int b)
// {
//     if (b == 0)
//     {
//         return 1;
//     }

//     int defaultValue = a;

//     for (int i = 1; i < b; i++)
//     {
//         a = a * defaultValue;
//     }

//     return a;
// }

//Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. Через строку решать нельзя.
// int n = int.Parse(Console.ReadLine());

// int result = DigitSum(n);

// Console.WriteLine("Сумма цифр числа " + n + " = " + result);

// Console.ReadLine();


//     int DigitSum(int n)
//     {
//         int temp = n;
//         int lastDigit = 0;

//         int sum = 0;

//         while (temp > 0)
//         {
//             lastDigit = temp % 10;
//             temp /= 10;
//             sum = sum + lastDigit;
//         }

//         return sum;
//     }
//Задача 29: Напишите программу, которая задаёт массив из 8 целых чисел с клавиатуры и далее выводит массив на экран в одну строку.

int[] array = new int[8];

for (int i = 0; i < array.Length; i++)
{
array[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i]);
}

Console.ReadLine();