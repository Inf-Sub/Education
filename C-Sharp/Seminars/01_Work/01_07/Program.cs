﻿/*
Итерация - повторение какого-либо действия

Задача №7. Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
	456 -> 6
	782 -> 2
	918 -> 8

*/

while (true)
{
    Console.Clear();

    Console.WriteLine(
        "Задача №7. Напишите программу, которая принимает на вход трёхзначное число\n" +
        "и на выходе показывает последнюю цифру этого числа.\n"
    );

    Console.Write("Введите целое трехзначное число: ");
    int a = Convert.ToInt32(Console.ReadLine());
    if (a < 100 || a > 999)
    {
        Console.WriteLine($"Вы ввели НЕ трехзначное число, ваше число: {a}. Попробуйте еще раз!");
        System.Threading.Thread.Sleep(2000);
    }
    else
    {
        Console.WriteLine($"{a % 10}");
        break;
    };
};
