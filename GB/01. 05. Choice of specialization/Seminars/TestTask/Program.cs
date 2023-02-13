
Run();


void Run(){
    string rn = "\n";
    string title = 
        $"Контрольная работа.{rn}"+
        $"Задача:{rn}"+
        $"Напишите программу, которая из имеющегося массива строк формирует массив из строк,{rn}"+
        $"длина которых меньше либо равна 3 символам.{rn}"+
        $"{rn}"+
        $"Например:{rn}"+
        $"['hello', '2', 'world', ':-)'] -> ['2', ':-)']{rn}"+
        $"['1234', '1567', '-2', 'computer science'] -> ['-2']{rn}"+
        $"['Russia', 'Denmark', 'Kazan'] -> []{rn}";

    string[][] arrWords = {
        new string[]{"hello", "2", "world", ":-)"},
        new string[]{"1234", "1567", "-2", "computer science"},
        new string[]{"Russia", "Denmark", "Kazan", "Ufa", "Omsk"},
        new string[]{ "Sunday", "Monday", "Tuersday", "Wednesday", "Thirsday", "Friday", "Saturday" },
        // add your array here
    };

    ViewTitleTask(title);
    
    Console.Clear();

    for(int i = 0; i < arrWords.Length; i++){
        Console.WriteLine($"[{String.Join(",", ShowSmallWord(arrWords[i], 3))}]");
    };

    Console.WriteLine(); 
};

/*
string[] ShowSmallWord(string[] arr, int chars){
    int len = arr.Length;
    string[] arrSmallWords;
    int count = 0;

    for(int i = 0; i < len; i++){
        if(arr[i].Length <= chars){
            count++;
        };
    };

    arrSmallWords = new string[count];
    count = 0;
    for(int i = 0; i < len; i++){
        if(arr[i].Length <= chars){
            arrSmallWords[count++] = arr[i];
        };
    };
    return arrSmallWords;  
};*/


string[] ShowSmallWord(string[] arr, int chars){
    int len = arr.Length;
    string smallWords = String.Empty;
    int k = 0;

    for(int i = 0; i < len; i++){
        if(arr[i].Length <= chars){
            if(k > 0){
                smallWords += ",";
            };
            k++;
            smallWords += $"{arr[i]}";
        };
    };
    return smallWords.Split(",");
};



// ViewTitleTask version 2.1
void ViewTitleTask(string? text = ""){
    string rn = "\n";
    Console.Clear();
    Console.WriteLine(
        $"{text}{rn}"+
        $"Для завершения программы, нажмите Ctrl + C{rn}{rn}"+
        $"Press any key to continue..."
    );
    Console.ReadKey();
    Console.Clear();
};
