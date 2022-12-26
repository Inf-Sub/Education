/*
Задача 10: 
Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
*/



int a;
int b;
int typeTask = 0;

void WaitSeconds(double sec)
{
    System.Threading.Thread.Sleep((int)(sec * 1000));
};


while (true)
{
    Console.Clear();

    Console.WriteLine(
        "Задача №10.\n"+
        "Напишите программу, которая принимает на вход трёхзначное число\n"+
        "и на выходе показывает вторую цифру этого числа.\n"
    );
    if(typeTask == 0){
        Console.Write("Введите 1 для ручного ввода числа или 2 для генерации рандомного числа: ");
        typeTask = Convert.ToInt32(Console.ReadLine());
    };
    
    
    if(typeTask == 1){
        Console.Write("Введите целое трехзначное число: ");
    a = Convert.ToInt32(Console.ReadLine());
    }else{
        a = new Random().Next(100, 1000);
    };
    b = a;

    if(b < 0){
        b *= -1;
    };
    
    if ((b < 100 || b >= 1000))
    {
        Console.WriteLine($"Вы ввели НЕ трехзначное число, ваше число: {a}. Попробуйте еще раз!");
        WaitSeconds(3);
    }
    else
    {
        Console.WriteLine($"{a} => {b % 100 / 10}");
        break;
    };
};