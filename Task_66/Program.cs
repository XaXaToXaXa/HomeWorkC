﻿//  Задайте значения M и N. Напишите программу, 
// которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите первое целое число: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Введите второе целое число: ");
int secondNumber = int.Parse(Console.ReadLine());

if (firstNumber == secondNumber) Console.WriteLine("Для получения результата числа должны быть разными.");
else
{
    if (firstNumber < secondNumber)
    {
        Console.Write($"N = {firstNumber}; M = {secondNumber} => {NumbersSum(firstNumber, secondNumber)}");
        Console.WriteLine();
    }
    else
    {
        Console.Write($"N = {firstNumber}; M = {secondNumber} => {NumbersSum(secondNumber, firstNumber)}");
        Console.WriteLine();
    }
}
int NumbersSum(int start, int end)
{
    int result = 0;

    if (start == end + 1) return result;
    else return result = start + NumbersSum(start + 1, end);

}
