/*
Урок 4. Функции
Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]

6, 1, 33 -> [6, 1, 33]
*/


using System.Text.RegularExpressions;


Run();
void Run(){
    bool debug = DebugMode();
    //ProgressBar();

    string rn = "\n";
    string title = $"Урок 4. Функции. Задача 29: {rn}"+
                   $"Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.{rn}{rn}"+
                   $"Например:{rn}"+
                   $"1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]{rn}"+
                   $"6, 1, 33 -> [6, 1, 33]{rn}";
    double[] result;


    while(true){
        ViewTitleTask(title);
        WaitSeconds(1);
        ExitFromProg(false);


        result = ReadDoubleArrayFromString("Введите несколько числел через пробел:", ' ', debug);


        ShowArrayDouble(result);

        if(!debug){
            WaitSeconds(5);
        }else{
            WaitSeconds(15);
        };
    };
};




double[] ReadDoubleArrayFromString(string write, char delimiter, bool debug = false){
    char[] charsToTrim = {' '};
    string pattern = @"^((\d+,\d+)|(\d+))((\s\d+,\d+)|(\s\d+))+$";
    string[] strNumbers;
    double[] arrayDouble;

    while(true){
        // выводим запрос данных
        Console.Write($"{write}");
        // считываем данные
        string? text = Console.ReadLine()?.Trim(charsToTrim).Replace(".", ",");

        // проверяем что строка не пуста
        if(text != ""){
            // проверяем не введена ли команда для выхода 000
            ExitFromProg(true, text);

            // проверяем данные на соответствие
            if(Regex.IsMatch(text, pattern, RegexOptions.IgnoreCase) ){
                // преобразуем строку в строковой массив
                strNumbers = text.Split(delimiter);

                // конвертируем значения массива в число типа double
                int length = strNumbers.Length;
                arrayDouble = new double[length];

                for(int i = 0; i < strNumbers.Length; i++){
                    arrayDouble[i] = Convert.ToDouble(strNumbers[i]);
                    if(debug){Console.WriteLine(arrayDouble[i]);};
                };
                return arrayDouble;
            }else{
                Console.WriteLine($"Attention: the data is incorrect!!!");
                WaitSeconds(1);
            };
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


void ViewTitleTask(string? text = ""){
    Console.Clear();
    Console.WriteLine($"{text}");
    Console.WriteLine();
};

/*
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
*/

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


void ShowArrayDouble(double[] array){
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