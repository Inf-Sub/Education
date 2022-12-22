/*
Задача №11. Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98
*/

Console.Clear();

Console.WriteLine($"Задача №11. Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.");
int a = new Random().Next(100, 1000);
int first = a % 10;
int second = (a % 100) / 10;
int third = a / 100;
Console.WriteLine($"a: {a}; first: {first}; second: {second}; third: {third}");
int result = third * 10 + first;
Console.WriteLine($"{result}");

/*
Напишите программу, которая выводит случайное трехзначное число и удаляет вторую цифру этого числа.

456 -> 46
782 -> 72
918 -> 98
*/
/*
Console.Clear();
int numb = new Random().Next(100, 1000);

Console.WriteLine(numb);

Console.Write((numb / 100) );
Console.WriteLine((numb % 10));
*/