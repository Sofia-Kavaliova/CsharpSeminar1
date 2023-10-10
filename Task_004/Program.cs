﻿// Код, который на вход принимает число (number),
// а на выходе выводит все чётные числа от 1 до number (включительно),
// разделеные знаком табуляции.

Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine ());

for (int N=2; N<=number; N+=2)
{
    Console.Write(N + "\t");
}