/*
Урок 4. Функции
Задача 25: 
Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

3, 5 -> 243 (3⁵)

2, 4 -> 16
*/



Run();


void Run(){
    bool debug = DebugMode();
    ProgressBar();

    string rn = "\n";
    string title = $"Урок 4. Функции. Задача 25: {rn}"+
                   $"Напишите цикл, который принимает на вход два числа (A и B){rn}"+
                   $"и возводит число A в натуральную степень B.{rn}";
    double A;
    double B;
    double result = 0;


    while(true){
        ViewTitleTask(title);
        WaitSeconds(1);
        ExitFromProg(false);
        A = ReadDoubleFromString("Введите целое число (A):");
        B = ReadDoubleFromString("Введите целое число (B) для возведения числа A в степень B:");

        result = RaiseTheNumberToTheDegree(A, B, debug);

        Console.WriteLine($"({A}) ^ {Math.Abs(B)} = {result}");

        if(!debug){
            WaitSeconds(3);
        }else{
            WaitSeconds(10);
        };
    };

};


double RaiseTheNumberToTheDegree(double num, double degree, bool debug = false){
    double result = num;
    degree = Math.Abs(degree);

    if(degree == 0){
        result = 1;
    };

    for(int i = 2; i <= degree; i++){
        result *= num;
        if(debug){Console.WriteLine($"Cycle {i-1}: ({num}) ^ {i} = {result}");};
    };

    if(debug){
        Console.WriteLine();
        Console.WriteLine(
            $"({num}) ^ {degree} = {result} || " + 
            $"Math.Pow({num}, {degree}) = {Math.Pow(num, degree)}"
        );
        Console.WriteLine();
    };

    return result;
};


bool DebugMode(){
    int status = ReadIntegerFromString("Use Debug Mode? (1 - yes / 0 - no):");
    return (status != 0) ? true : false;
};


void WaitSeconds(double sec){
    System.Threading.Thread.Sleep((int)(sec * 1000));
};


void ViewTitleTask(string? text = ""){
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


