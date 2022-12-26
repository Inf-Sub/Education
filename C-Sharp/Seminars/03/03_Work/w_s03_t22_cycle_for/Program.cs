//Напишите программу, которая принимает на вход число (N) 
//и выдаёт таблицу квадратов чисел от 1 до N.

Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine());

/*
for(int i = 1; i <= N; i++)
{
    Console.Write($"{i*i} ");
};
Console.WriteLine();
*/
for(int i = 1; i <= N; i++)
{
    Console.Write($"{Math.Pow(i, 2)} ");
};
