/*
Задача 13:
Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет

645 -> 5
78 -> третьей цифры нет
32679 -> 6
*/

int num;
int module;
int typeTask = 0;

void WaitSeconds(double sec)
{
    System.Threading.Thread.Sleep((int)(sec * 1000));
};


while (true)
{
    Console.Clear();

    Console.WriteLine(
        "Задача 13:\n"+
        "Напишите программу, которая выводит третью цифру заданного\n"+
        "числа или сообщает, что третьей цифры нет.\n"
    );

    Console.WriteLine(
        "Press Ctrl+C for Exit.\n"
    );

    if(typeTask == 0){
        Console.Write("Введите 1 для ручного ввода числа или 2 для генерации рандомного числа: ");
        typeTask = Convert.ToInt32(Console.ReadLine());
    };

    if(typeTask == 1){
        Console.Write("Введите целое число: ");
    num = Convert.ToInt32(Console.ReadLine());
    }else{
        num = new Random().Next(-10000, 10000);
    };
    module = (num >= 0) ? num : num * -1;

    if(module < 100){
        Console.WriteLine($"В числе {num} - третьей цифры нет!");
    }else{
        Console.WriteLine($"{num} => {module / 100 % 10}");
    };        
    WaitSeconds(2);
};