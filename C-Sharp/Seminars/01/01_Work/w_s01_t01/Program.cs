/*
Итерация 

Задача №1. Напишите программу, которая на вход принимает два числа и проверяет, является ли первое число квадратом второго.
a = 25, b = 5 -> да 
a = 2, b = 10 -> нет 
a = 9, b = -3 -> да 
a = -3 b = 9 -> нет
*/

int a, b, i, len, task_version;
int[ , ] array = { {25, 5}, { 2, 10 }, {9, -3}, {-3, 9} };

// string result;


void WaitSeconds(double sec)
{
    System.Threading.Thread.Sleep((int)(sec * 1000));
};
    


Console.Clear();

Console.WriteLine(
    "ЗАДАЧА 1: Введите два числа, для проверки, является ли первое число квадратом второго:\n"+
    "\n"
);

WaitSeconds(1);

Console.WriteLine(
    "Введите 1, если вы хотите вводить числа вручную в окно консоли или\n"+
    "введите 2, если программа должна взять числа заданные в задаче:"
);
task_version = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введен вариант: {task_version}");

WaitSeconds(1);

if(task_version == 1){
    while(true){
        Console.Clear();
        Console.Write($"Введите первое число: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Введите второе число: ");
        b = Convert.ToInt32(Console.ReadLine());

        WaitSeconds(0.5);

        Console.WriteLine(
            $"Результат проверки: a = {a} b = {b} -> {((b * b == a) ? "ДА" : "НЕТ")} "+
            $"(число {a} - {((b * b == a) ? "ДА" : "НЕ")} является квадратом числа {b})"
        );

        WaitSeconds(2);
        
        // Console.Clear();

        Console.WriteLine(
            $"\n"+
            "Еще разок? Нажмите ENTER для продолжения!"
        );
        if(Console.ReadLine() != ""){
            break;
        };
    };
}else if(task_version == 2){
    // len = array.Length / 2;
    len = array.GetUpperBound(0) + 1;
    i = 0;
    
    Console.Clear();

    while(i < len){
        // Console.WriteLine($"{i} < {len} = {i < len} {array.GetUpperBound(0)}");
        a = array[i, 0];
        b = array[i, 1];
        i++;
        
       Console.WriteLine(
            $"Результат проверки: a = {a} b = {b} -> {((b * b == a) ? "ДА" : "НЕТ")} "+
            $"(число {a} - {((b * b == a) ? "ДА" : "НЕ")} является квадратом числа {b})"
        );

        WaitSeconds(1);
    };
}else{
    Console.Clear();
    i = 5;
    Console.WriteLine("ВНИМАНИЕ: Вы допустили ошибку, самоуничтожение через:");
        while(i > 0){
        Console.WriteLine(i--);
        // await Task.Delay(1000);
        WaitSeconds(1);
    };    
    Console.Clear();
    Console.WriteLine("*Bonk*");
};
