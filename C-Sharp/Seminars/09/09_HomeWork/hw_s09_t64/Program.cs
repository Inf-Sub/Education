/*
Урок 9. Рекурсия
Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

N = 5 -> "5, 4, 3, 2, 1"
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

*/

Console.Clear();
Console.WriteLine(
    $"Задача 64:\nЗадайте значение N. Напишите программу, которая выведет все натуральные числа\n" +
    $"в промежутке от N до 1. Выполнить с помощью рекурсии.\n"
);
Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
Console.Clear();


numbersAtN2One(N);

void numbersAtN2One(int start, int end = 1){
    Console.Write($"{start} ");
    if(start == end){return;};
    numbersAtN2One(start - 1, end);
};
