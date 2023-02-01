﻿// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введите положительное целое число: ");
int number = int.Parse(Console.ReadLine());

Console.Write($"{number}, => ");
NumbersLine(number);

void NumbersLine(int n)
{
    Console.Write($"{n}, ");
    if (n == 1) return;
    else NumbersLine(n - 1);
}