﻿/*
Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/


bool DebugMode(int status = 0){
    return (status != 0) ? true : false;
};

void WaitSeconds(double sec){
    System.Threading.Thread.Sleep((int)(sec * 1000));
};

void ExitFromProg(bool exit = true, string? text = ""){
    if(!exit){
        Console.WriteLine($"!!!!! Для выхода введите 000 и нажмите ENTER !!!!!");
    };
    if(text == "000"){
        Console.Clear();
        Console.WriteLine("I'll be back...");
        System.Environment.Exit(0);
    };
    Console.WriteLine();      
};

/* 
bool ExitFromProg(string? text = ""){
    bool result;

    if(text != ""){
        Console.WriteLine($"{text}");
    };
    Console.WriteLine();
    Console.Write(
        $"Нажмите ENTER для продолжения или любую клавишу, и затем ENTER - для выхода из программы "
    );

    result = (Console.ReadLine() != "") ? true : false;
    Console.WriteLine();

    return result;
};
*/

int ReadIntegerFromString(string write){
    while(true){
        Console.Write($"{write} ");
        string? text = Console.ReadLine();

        if(text != ""){
            ExitFromProg(true, text);
            return Convert.ToInt32(text);
        }else{
            Console.WriteLine($"Attention: the data is incorrect!!!");
            WaitSeconds(1);
        };
    };    
};

void TitleTask(string? text = ""){
    Console.Clear();
    Console.WriteLine($"{text}");
    Console.WriteLine();
};

int SelectDaysType(){
    string rn = "\n";
    string[] types = {"Все дни", "Выходные дни", "Будние дни"};
    string text = $"Выберите тип дней недели:{rn}{rn}";
    int result;
    int len = types.Length;
    int i = 0;
    while(i < len){
        text += $"{i + 1}. {types[i]};{rn}";
        i++;
    };
    text += $"{rn}Введите номер выбранного типа:";

    while(true){
        result = ReadIntegerFromString(text) - 1;
        if(result >= 0 && result < len){
            Console.Clear();
            Console.WriteLine($"Выбраны: {types[result]}");
            WaitSeconds(2);

            return result;
        };
    };
};

void DayOfWeek(int day, int type = 0, bool debug = false){
    if(debug) Console.WriteLine($"day: {day}\n");

    if(day == 0){
        day = 7;
    };
    
    if(type == 0 || type == 2){
        switch (day){
            case 1:
                Console.WriteLine($"Нас тупило утро ПОНЕДЕЛЬНИКА");
                //Console.WriteLine("Чем дальше от понедельника, тем добрее утро.");
                break;

            case 2:
                Console.WriteLine($"На улице был ВТОРНИК, а на душе – вечер пятницы…");
                break;

            case 3:
                Console.WriteLine($"СРЕДА - это маленькая пятница!");
                break;

            case 4:
                Console.WriteLine($"ЧЕТВЕРГ рыбный день - пойду раздам лещей!");
                break;

            case 5:
                Console.WriteLine($"ПЯТНИЦА — друг человека!");
                break;

            default:
                if(debug && type != 0) Console.WriteLine($"Attention: Value is {day}.");
                break;
        };
    };
    if(type == 0 || type == 1){
        switch (day){
            case 6:
                Console.WriteLine($"Прожить неделю надо так, чтоб ничто не испортило СУББОТУ!");
                break;

            case 7:
                Console.WriteLine($"Какая наглость, соседи! Шуметь в ВОСКРЕСЕНЬЕ, в 15 часов утра!");
                break;

            default:
                if(debug && type != 0) Console.WriteLine($"Attention: Value is {day}.");
                break;
        };
    };
};

void DisplayDayOfWeekEnd(string? title = ""){
    bool debug;
    string rn = "\n";
    int day;
    int dayType = -1;

    debug = DebugMode(ReadIntegerFromString("Use Debug Mode? (1 - yes / 0 - no):"));


    while (true){
        if(title != ""){
            TitleTask(title);
        };

        if(debug) Console.WriteLine($"DEBUG MODE: {debug}{rn}");

        if(dayType < 0){
            dayType = SelectDaysType();
            continue;
        };

        ExitFromProg(false);

        day = ReadIntegerFromString("Введите номер дня недели:");

        if(debug) Console.WriteLine($"Введен номер: {day}");

        switch (day){
            case > 0:
                if(debug) Console.WriteLine(
                    $"sun: {day % 7 == 0} || sat: {(day + 1) % 7 == 0} => "+
                    $"{day % 7 == 0 || (day + 1) % 7 == 0}{rn}"+
                    $"sun: {day % 7} == 0; sat: {(day + 1) % 7} == 0; day: {day}{rn}"
                );

                DayOfWeek(day % 7, dayType, debug);
                break;

            case < 0:
                day += -7;
                if(debug) Console.WriteLine(
                    $"sun: {(day -6) % 7 == 0} || sat: {(day -5) % 7 == 0} => "+
                    $"{(day -6) % 7 == 0 || (day -5) % 7 == 0}{rn}"+
                    $"sun: {(day -6) % 7} == 0; sat: {(day -5) % 7} == 0; day: {day}{rn}"
                );
                
                DayOfWeek(((day % 7) + 8) % 7, dayType, debug);
                break;

            default:
                Console.WriteLine(
                    $"Номер дня недели не может быть равен {day}{rn}"+
                    $"Пожалуйста, попробуйте снова"
                );
                break;
        };

        WaitSeconds(2);
    };
};

void Run(){
    string rn = "\n";
    string title =
        $"Задача 15 (Advanced Mode):{rn}" +
        $"\tНапишите программу, которая принимает на вход цифру, обозначающую{rn}" +
        $"\tдень недели, и проверяет, является ли этот день выходным.";

    DisplayDayOfWeekEnd(title);
};

Run();