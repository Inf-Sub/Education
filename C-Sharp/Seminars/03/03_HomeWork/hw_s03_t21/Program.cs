/*
Задача 21:
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53
*/


Console.Clear();

Console.WriteLine(
    $"Задача 21:\n"+
    $"Напишите программу, которая принимает на вход координаты двух точек\n"+
    $"и находит расстояние между ними в 3D пространстве.\n"
);

// dot 1
Console.Write("Введите X1: ");
int x1=int.Parse(Console.ReadLine());
Console.Write("Введите Y1: ");
int y1=int.Parse(Console.ReadLine());
Console.Write("Введите Z1: ");
int z1=int.Parse(Console.ReadLine());
// dot 2
Console.Write("Введите X2: ");
int x2=int.Parse(Console.ReadLine());
Console.Write("Введите Y2: ");
int y2=int.Parse(Console.ReadLine());
Console.Write("Введите Z2: ");
int z2=int.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2));

// форматирование вывода через :f= количество знаков после запятой
Console.WriteLine($"d={d:f2}");
