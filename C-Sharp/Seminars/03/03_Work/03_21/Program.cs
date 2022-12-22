/*
Задача №21.
Напишите программу, которая принимает на вход
координаты двух точек и находит расстояние между
ними в 2D пространстве
*/

Console.Clear();
Console.Write("Введите X1: ");
int x1=int.Parse(Console.ReadLine());
Console.Write("Введите Y1: ");
int y1=int.Parse(Console.ReadLine());
Console.Write("Введите X2: ");
int x2=int.Parse(Console.ReadLine());
Console.Write("Введите Y2: ");
int y2=int.Parse(Console.ReadLine());

double d = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2));

Console.WriteLine($"d={d:f3}");
