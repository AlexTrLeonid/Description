﻿// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.WriteLine("Введите число N ");
int N = int.Parse(Console.ReadLine()!);
int d = 1;
while (d <= N)
{
    if (d % 2 == 0)
        Console.Write($"{d}   ");
    d++;
}