﻿// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

System.Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());
int index = 1;
while (index <= number)
{
    Console.WriteLine(Math.Pow(index, 3));
    index++;
}

