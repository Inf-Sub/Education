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





Console.Clear();

Console.WriteLine(
    "ЗАДАЧА 1: Введите два числа, для проверки, является ли первое число квадратом второго:\n"+
    "\n"
);
System.Threading.Thread.Sleep(1000);
Console.WriteLine(
    "Введите 1, если вы хотите вводить числа вручную в окно консоли или\n"+
    "введите 2, если программа должна взять числа заданные в задаче:"
);
task_version = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введен вариант: {task_version}");
System.Threading.Thread.Sleep(1000);

if(task_version == 1){
    while(true){
        Console.Clear();
        Console.Write($"Введите первое число: ");
        a = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Введите второе число: ");
        b = Convert.ToInt32(Console.ReadLine());
        System.Threading.Thread.Sleep(500);

        if(b != 0){
            // result = (a / b == b) ? "ДА" : "НЕ";
            Console.WriteLine(
                $"Результат проверки: число {a} - {((a / b == b) ? "ДА" : "НЕ")} является квадратом числа {b}"
            );
        }else{
            Console.WriteLine($"Переменная b == {b}, деление на {b} запрещено!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("*Bonk*");
        };
        System.Threading.Thread.Sleep(2000);
        
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
        

        if(b != 0){
            // result = (a / b == b) ? "ДА" : "НЕ";
            Console.WriteLine(
                $"Результат проверки: число {a} - {((a / b == b) ? "ДА" : "НЕ")} является квадратом числа {b}"
            );
        }else{
            Console.WriteLine($"Переменная b == {b}, деление на {b} запрещено!");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine("*Bonk*");
        };
        System.Threading.Thread.Sleep(1000);
    };
}else{
    Console.Clear();
    i = 5;
    Console.WriteLine("ВНИМАНИЕ: Вы допустили ошибку, самоуничтожение через:");
        while(i > 0){
        Console.WriteLine(i--);
        // await Task.Delay(1000);
        System.Threading.Thread.Sleep(1000);
    };    
    Console.Clear();
    Console.WriteLine("*Bonk*");
};
