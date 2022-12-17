/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее

*/
string read;
double a, b, min, max;

while (true)
{
    Console.Clear();

    Console.WriteLine(
        "Задача 2: Напишите программу, которая на вход принимает два числа и выдает, какое число большее, а какое меньшее.\n"
    );

    Console.Write("Введите первое число: ");
    read = Console.ReadLine();
    read = read.Replace(".", ",");
    a = Convert.ToDouble(read);

    Console.Write("Введите первое число: ");
    read = Console.ReadLine();
    read = read.Replace(".", ",");
    b = Convert.ToDouble(read);

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