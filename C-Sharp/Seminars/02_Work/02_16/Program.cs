/*
Задача №16. Работа в группах
Напишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.

5, 25 -> да
-4, 16 -> да
25, 5 -> да
8,9 -> нет
*/



Console.Clear();

Console.WriteLine(
    $"Задача №16.\n" +
    $"\tНапишите программу, которая принимает на вход два числа и проверяет, является ли одно число квадратом другого.\n"
);


int first;
int second;
int i = 0;
int count = 10000;
while (i++ < count)
{
    first = new Random().Next(1, 10000);
    second = new Random().Next(1, 10000);

    if (
        (first == second * second) ||
        (second == first * first)
    )
    {
        if (first == second * second)
        {
            Console.WriteLine($"Число {first} является квадратом {second}");
        }
        else
        {
            Console.WriteLine($"Число {second} является квадратом {first}");
        };
    }else{
        //Console.WriteLine($"Числа {first} и {second} не являются квадратами друг друга.");
    };

};
