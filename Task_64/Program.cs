﻿// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите положительное целое число: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 1)
{
Console.Write($"N = {number} => ");
NumbersLine(number);
Console.Write("1");
Console.WriteLine();

void NumbersLine(int n) // Для красоты вывода выход происходиит на 2
{
    Console.Write($"{n}, ");
    if (n == 2) return;
    else NumbersLine(n - 1);
}
}
else Console.WriteLine("Число дожно быть больше 1");