﻿// Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16


Console.Write("Введите первое число: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int b = Convert.ToInt32(Console.ReadLine());
int pow = a;

for (int i = 1; i < b; i++)
{
pow = pow * a;
}
Console.WriteLine($"Число {a} в степени {b} равно: " + pow);
