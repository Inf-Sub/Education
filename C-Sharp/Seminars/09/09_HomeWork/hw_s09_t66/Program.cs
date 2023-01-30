/*
Урок 9. Рекурсия
Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/


Console.Clear();
Console.WriteLine(
    $"Задача 66:\nЗадайте значения M и N. Напишите программу, которая\n" +
    $"найдёт сумму натуральных элементов в промежутке от M до N.\n"
);
Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine());
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());
Console.Clear();

Console.WriteLine($"M = {((M < N) ? M : N)}; N = {((M < N) ? N : M)} -> {SumNumbers(N, M)}");

int SumNumbers(int x, int y){
    int min = (x < y) ? x : y;
    int max = (x < y) ? y : x;
    if(min == max){return min;};
    //long sum = min * 2 + 1;
    return min += SumNumbers(min + 1, max);
};