/*
//Задача 44. Не используя рекурсию, выведите первые N чисел Фибоначчи.
//Первые два числа Фибоначчи: 0 и 1.
//Если N = 5 -> 0 1 1 2 3
//Если N = 3 -> 0 1 1
//Если N = 7 -> 0 1 1 2 3 5 8
*/



Run();

void Run(){
    int fib;
    while(true){
        fib = ReadIntegerFromString($"Введите номер числа Фибоначчи:");
        Console.WriteLine($"STRING: ");
        FibonacciString(fib);
        Console.WriteLine($"ARRAY: ");
        FibonacciArray(fib);
        Console.WriteLine($"RECURSIVE STRING: ");
        FibonacciRecurciveString(fib);
        Console.WriteLine($"RECURSIVE ARRAY: ");
        FibonacciRecurciveArray(new long[fib]);        
    };
};

void FibonacciString(int num){
    Console.Write($"Fibonacci {num}: ");
    if(num == 1) Console.Write($"0");
    if(num >= 2){
        Console.Write($"0 1");

        long prev = 0;
        long curr = 1;
        long temp;
        for(int i = 0; i < num-2; i++){
            temp = curr;
            //Console.WriteLine($"\nprev: {prev} curr: {curr} temp {temp} next {curr + prev}");
            curr += prev;
            prev = temp;
            Console.Write($" {curr}");
        };
    };
    Console.WriteLine("\n");
};

void FibonacciArray(int num){
    long[] FibList = new long[num + 1];
    
    Console.Write($"Fibonacci {num}:");
    FibList[0] = 0;

    if(num >= 1) Console.Write($" {FibList[0]}");

    if(num >= 2){
        FibList[1] = 1;
        Console.Write($" {FibList[1]}");

        for(int i = 2; i < num; i++){
            FibList[i] = FibList[i-1] + FibList[i-2];
            Console.Write($" {FibList[i]}");
        };
    };

    Console.WriteLine("\n");
};


long FibonacciRecurciveString(int num, long first = 0, long second = 1, int deep = 2){    
    long current;
    string str = String.Empty;

    if(first == 0){
        Console.Write($"Fibonacci {num}: ");
        if(num >= 1) Console.Write($"0");
    };
    
    current = first + second;    

    if(num > 1) Console.Write($" {current}");

    if(deep < num){
        str += $" {FibonacciRecurciveString(num, current, first, ++deep)}";
    };

    if(first == 0) Console.WriteLine($"\n");

    return current;
};


void FibonacciRecurciveArray(long[] FibList, int deep = 2){    
    int num = FibList.Length;
   
    if(deep == 2){
        Console.Write($"Fibonacci {num}: ");

        if(num >= 1){
            FibList[0] = 0;
            Console.Write($"{FibList[0]}");
        };
        if(num >= 2){
            FibList[1] = 1;
            Console.Write($" {FibList[1]}");
        };
    };

    if(num > 2 && deep < num){
        FibList[deep] = FibList[deep-1] + FibList[deep-2];
        Console.Write($" {FibList[deep]}");

        FibonacciRecurciveArray(FibList, deep+1);
    };

    if(deep == 2) Console.WriteLine($"\n");
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

