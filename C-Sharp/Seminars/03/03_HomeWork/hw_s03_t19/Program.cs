/*
Задача 19: 
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
23432 -> да
12821 -> да
*/



Run();

void CheckPalindrome(int number, bool debug = false){
    int origin_number = number;
    int rev = 0;

    while(number > 0){
        rev = rev * 10 + (number % 10);
        if(debug) Console.WriteLine($"origin_number = {origin_number}; number = {number}; rev = {rev}");
        number /= 10;
    };

    Console.WriteLine(
        $"{origin_number} - это"+
        $"{((origin_number == rev) ? " " : " не ")}"+
        $"палиндром!"
    );
};

void Run(){
    bool debug = DebugMode();
    string rn = "\n";
    string title = 
        $"Задача 19:{rn}"+
        $"Напишите программу, которая принимает на вход пятизначное число{rn}"+
        $"и проверяет, является ли оно палиндромом.{rn}";
    string task = $"Введите пятизначное число:";

    while(true){
        TitleTask(title);
        ExitFromProg(false);

        int num = ReadIntegerFromString(task);

        if(debug) Console.WriteLine($"num: {num}; if: {(num < 10000 || num >= 100000)} => ({num < 10000} || {num >= 100000})");
        if(num < 10000 || num >= 100000){
            Console.WriteLine($"Ошибка: число должно быть пятизначным, введенное число: {num}!");
            WaitSeconds(3);
            continue;
        };

        CheckPalindrome(num, debug);
        if(!debug){
            WaitSeconds(3);
        }else{
            WaitSeconds(10);
        };
    };
};



bool DebugMode(){
    int status = ReadIntegerFromString("Use Debug Mode? (1 - yes / 0 - no):");
    return (status != 0) ? true : false;
};

void WaitSeconds(double sec){
    System.Threading.Thread.Sleep((int)(sec * 1000));
};

void TitleTask(string? text = ""){
    Console.Clear();
    Console.WriteLine($"{text}");
    Console.WriteLine();
};

void ProgressBar(){    
    Console.Clear();
    Console.WriteLine("Loading...");
    for(int i = 0; i < 100; i++){
        Console.Write($"#");
        WaitSeconds(0.015);
    };
    WaitSeconds(1);
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
