﻿// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Clear();
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int evenNumber = number%2;
if(evenNumber == 0)
{
    Console.Write("Число " + number + " является четным");
}
else
{
    Console.Write("Число " + number + " является нечетным");
}