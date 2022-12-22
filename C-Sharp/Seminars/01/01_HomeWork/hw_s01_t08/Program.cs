/*
Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Возможности:
- Вывод чётных положительных и отрицательных чисел от 1 до N;
- сортировка чисел, как положительных, так и отрицательных, как в задаче от 1 до N

*/

Console.Clear();

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




/* 
// Code by Alexander Talan (for test and optimize)

Console.Write($"Введите целое число: ");

int NumberA = Convert.ToInt32(Console.ReadLine());
int NumberB = 1;
// int NumberC = NumberA + Math.Sign(NumberA);


Console.WriteLine($"Ряд четных чисел от 1 до {NumberA}:");

if (NumberA == 0)
{
    NumberB = 0;
    Console.Write($"{NumberB}");
};

NumberA += Math.Sign(NumberA);

while (!(NumberB <= NumberA) || !(NumberB >= NumberA))
{    
    //Console.WriteLine(
    //    $"\nNumberA = {NumberA}; NumberB = {NumberB}; NumberC = {NumberC}; Math.Sign(NumberA) = {Math.Sign(NumberA)}\n"+
    //    $"({!(NumberB <= NumberA)} || {!(NumberB >= NumberA)}) == {!(NumberB <= NumberA) || !(NumberB >= NumberA)}\n"+
    //    $"(!({NumberB} <= {NumberA}) || !({NumberB} >= {NumberA}))\n"
    //);    
    //System.Threading.Thread.Sleep(200);

    if (NumberB % 2 == 0)
    {
        Console.Write($"{NumberB} ");
    };
    NumberB += Math.Sign(NumberA);
};
*/