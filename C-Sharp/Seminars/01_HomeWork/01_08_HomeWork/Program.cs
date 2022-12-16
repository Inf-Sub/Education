/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Возможности:
- Вывод чётных положительных и отрицательных чисел от 1 до N;
- сортировка чисел, как положительных, так и отрицательных, как в задаче от 1 до N

*/
Console.WriteLine(
    "Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.\n"
);

Console.Write("Введите целое число: ");
int N = Convert.ToInt32(Console.ReadLine());

int min = (1 < N) ? 1 : N;
int max = (1 > N) ? 1 : N;
string positive = "";
string negative = "";

if (min % 2 != 0)
{
    min++;
};

while (min <= max)
{
    positive += $"{min} ";
    negative = $"{min} {negative} ";
    min += 2;
};

if (max == N){
    Console.WriteLine(positive);
}else{
    Console.WriteLine(negative);
};




