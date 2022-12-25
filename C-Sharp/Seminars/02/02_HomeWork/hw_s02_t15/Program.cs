/*
Задача 15: 
Напишите программу, которая принимает на вход цифру, обозначающую день недели, 
и проверяет, является ли этот день выходным.

6 -> да
7 -> да
1 -> нет
*/


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

void TitleTask(string? text = ""){
    Console.Clear();
    Console.WriteLine($"{text}");
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

void DayOfWeek(int day){
    if(day == 0){
        day = 7;
    };
    
    switch (day){
        case < 6:
            Console.WriteLine($"Да - это будний день");
            break;

        case > 5:
            Console.WriteLine($"Нет - это выходной день");
            break;
    };
};



void DisplayDayOfWeekEnd(string? title = ""){
    string rn = "\n";
    int day;
    int num;
    
    while (true){
        TitleTask(title);

        ExitFromProg(false);

        day = ReadIntegerFromString("Введите номер дня недели:");


        switch (day){
            case > 0:
                DayOfWeek(day % 7); 
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
        $"Задача 15:{rn}" +
        $"\tНапишите программу, которая принимает на вход цифру, обозначающую{rn}" +
        $"\tдень недели, и проверяет, является ли этот день выходным.";

    DisplayDayOfWeekEnd(title);
};

Run();
