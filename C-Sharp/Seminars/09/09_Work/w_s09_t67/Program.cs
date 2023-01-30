/*
Задача 67: Напишите программу, которая будет принимать на вход число и возвращать сумму его цифр.
453 -> 12
45 -> 9

*/

while(true){
    Console.Write("Введите число: ");
    long N = long.Parse(Console.ReadLine());
    Console.WriteLine(SumNumber(N));
};


long SumNumber(long N){
    long sum = 0;
    if(N == 0){return 0;};
    Console.Write($"{N} ");
    sum += N % 10 + SumNumber(N / 10);
    return sum;
};