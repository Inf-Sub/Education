/*
Урок 4. Функции
Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

452 -> 11

82 -> 10

9012 -> 12
*/



Run();


void Run(){
    bool debug = DebugMode();
    ProgressBar();

    string rn = "\n";
    string title = $"Урок 4. Функции. Задача 27: {rn}"+
                   $"Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.{rn}{rn}"+
                   $"Например:{rn}"+
                   $"452  -> 11{rn}"+
                   $"82   -> 10{rn}"+
                   $"9012 -> 12{rn}";
    int number;
    int result = 0;


    while(true){
        TitleTask(title);
        WaitSeconds(1);
        ExitFromProg(false);
        number = ReadIntegerFromString("Введите целое число:");

        result = getSumOfNumbersInNumber(number, debug);

        Console.WriteLine($"{result}");

        if(!debug){
            WaitSeconds(3);
        }else{
            WaitSeconds(10);
        };
    };
};


int getSumOfNumbersInNumber(int number, bool debug = false){
    int result = 0;

    for(int i = 1; number != 0; i++){
        result += number % 10;
        number /= 10;
        if(debug){Console.WriteLine($"Cycle {i}: number = {number}; result = {result}");};
    };

    if(debug){Console.WriteLine();};

    return result;
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
    Console.WriteLine();
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

double ReadDoubleFromString(string write){
    char[] charsToTrim = {' '};
    while(true){
        Console.Write($"{write}");
        string? text = Console.ReadLine()?.Trim(charsToTrim).Replace(".", ",");

        if(text != ""){
            ExitFromProg(true, text);
            return Convert.ToDouble(text);
        }else{
            Console.WriteLine($"Attention: the data is incorrect!!!");
            WaitSeconds(1);
        };
    };
};


