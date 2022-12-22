/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее

*/
double a, b, min, max;

double ReadDoubleFromString(string write)
{
    Console.Write($"{write}");
    string? text = Console.ReadLine()?.Replace(".", ",");

    return Convert.ToDouble(text);
};

while (true)
{
    //Console.Clear();

    Console.WriteLine(
        "Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.\n"
    );

    a = ReadDoubleFromString("Введите первое число: ");
    b = ReadDoubleFromString("Введите второе число: ");

    if(a < b){
        min = a;
        max = b;
    }else{
        min = b;
        max = a;
    };

    Console.Write(
        $"Число {max} большее, а число {min} меньшее\n\n"+
        $"Нажмите ENTER для продолжения или любую клавишу и затем ENTER для выхода из программы "
    );
    if (Console.ReadLine() != "")
    {
        break;
    };
};