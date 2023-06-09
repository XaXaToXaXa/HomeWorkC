﻿// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите первое целое положительное число: ");
int firstNumber = int.Parse(Console.ReadLine());

Console.Write("Введите второе целое положительное число: ");
int secondNumber = int.Parse(Console.ReadLine());


Console.WriteLine($"m = {firstNumber}, n = {secondNumber}, => A(m,n) = {Akkerman(firstNumber, secondNumber)}"); 

int Akkerman(int firstNumber, int secondNumber)
{
    if (firstNumber == 0)
    {
        return secondNumber + 1;
    }
    else if (secondNumber == 0 && firstNumber > 0)
    {
        return Akkerman(firstNumber - 1, 1);
    }
    else
    {
        return (Akkerman(firstNumber - 1, Akkerman(firstNumber, secondNumber - 1)));
    }
}