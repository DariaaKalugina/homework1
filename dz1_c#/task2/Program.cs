﻿// task 2
Console.Write("Введите первое число: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int m = Convert.ToInt32(Console.ReadLine());
if (m > n)
    Console.Write($"max = {m}");
else
    Console.Write($"max = {n}");
