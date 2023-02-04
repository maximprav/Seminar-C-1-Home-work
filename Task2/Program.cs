// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Clear();
Console.Write("Введите первое число: ");
int numberOne = int.Parse(Console.ReadLine());
Console.Write("Введите второе число: ");
int numberTwo = int.Parse(Console.ReadLine());
if (numberOne > numberTwo)
{
    Console.Write("Первое число " + numberOne + " является наибольшим");
    Console.Write(", Второе число " + numberTwo + " является наименьшим");
}
if (numberOne < numberTwo)
{
    Console.Write("Первое число " + numberOne + " является наименьшим");
    Console.Write(", Второе число " + numberTwo + " является наибольшим");
}