/*
Задача №12. Работа в группах 
Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. Если число 2 не кратно числу 1, то программа выводит остаток от деления.

34, 5 -> не кратно, остаток 4
16, 4 -> кратно
*/

char[] charsToTrim = {' '};

double ReadDoubleFromString(string write){
    Console.Write($"{write}");
    string? text = Console.ReadLine()?.Trim(charsToTrim).Replace(".", ",");

    return Convert.ToDouble(text);
};


Console.Clear();

Console.WriteLine(
    $"Задача №12.\n"+
    $"\tНапишите программу, которая будет принимать на вход два числа и \n"+
    $"\tвыводить, является ли второе число кратным первому.\n"+
    $"\tЕсли число 2 не кратно числу 1, то программа выводит остаток от деления.\n"
);

double first = ReadDoubleFromString("Введите первое число: ");
double second = ReadDoubleFromString("Введите второе число: ");

//int first = new Random().Next(1, 1000);
//int second = new Random().Next(1, 1000);

if(first % second == 0){
    Console.WriteLine($"Число {first} кратно {second}");
}else{
    Console.WriteLine($"Число {first} НЕ кратно {second}, остаток от деления: {first % second}");
};
