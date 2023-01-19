/*
Урок 4. Функции
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/



Run();


void Run(){
    ProgressBar();

    string rn = "\n";
    string title = $"Урок 4. Функции. Задача 29: {rn}"+
                   $"Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.{rn}{rn}"+
                   $"Например:{rn}"+
                   $"1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]{rn}"+
                   $"6, 1, 33 -> [6, 1, 33]{rn}";
    int count;
    int min;
    int max;

    int[] result;


    while(true){
        ViewTitleTask(title);
        WaitSeconds(1);
        ExitFromProg(false);

        count = ReadIntegerFromString($"Введите длину массива:");
        min = ReadIntegerFromString($"Введите минимальное число в массиве:");
        max = ReadIntegerFromString($"Введите максимальное число в массиве:");


        result = CreateRandomArray(count, min, max);


        ShowArrayInt(result);

        WaitSeconds(5);
    };
};



int[] CreateRandomArray(int N, int start, int end){
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++){
        RandomArray[i] = new Random().Next(start, end + 1);
    };
    return RandomArray;
};


void ShowArrayInt(int[] array){
    int len = array.Length;
    Console.Write("[");
    for (int i = 0; i < len; i++){
        Console.Write(array[i]);
        if(i+1 < len){
            Console.Write(", ");
        };
    };
    Console.Write("]");
    Console.WriteLine();
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
