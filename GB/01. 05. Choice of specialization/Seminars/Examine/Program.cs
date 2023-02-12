
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

    ShowSmallWord(arrWords, 3);

    Console.WriteLine(); 
};


void ShowSmallWord(string[][] arr, int chars){
    int lenI = arr.Length;
    int lenJ;
    string[] arrSmallWords;

    for(int i = 0; i < lenI; i++){
        lenJ = arr[i].Length;
        arrSmallWords = new string[lenJ];
        int k = 0;

        for(int j = 0; j < lenJ; j++){
            arrSmallWords[j] = String.Empty;
            if(arr[i][j].Length <= chars){
                if(k > 0){
                    arrSmallWords[j] = ",";
                };
                k++;
                arrSmallWords[j] += $"'{arr[i][j]}'";
            };
        };
        Console.WriteLine($"[{String.Join(",", arr[i])}] -> [{String.Join("", arrSmallWords)}]");
    };    
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
