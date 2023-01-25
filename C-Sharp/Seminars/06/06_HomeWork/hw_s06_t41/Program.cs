/*
Урок 6. Одномерные массивы. Продолжение
Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

0, 7, 8, -2, -2 -> 2

1, -7, 567, 89, 223-> 3
*/


using System.Text.RegularExpressions;



Run();


void Run(){
    Console.Clear();

    string rn = "\n";
    string title =  
        $"Урок 6. Одномерные массивы.{rn}"+
        $"Задача 41:{rn}"+
        $"Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.{rn}"+
        $"{rn}"+
        $"Например:{rn}"+
        $"0, 7, 8, -2, -2 -> 2{rn}"+
        $"1, -7, 567, 89, 223-> 3{rn}"+
        $"{rn}";

    double[] arrayDouble;


    while(true){
        ViewTitleTask(title);
        WaitSeconds(1);

        arrayDouble = ReadDoubleArrayFromString($"Вводите с клавиатуры несколько чисел через пробел:");

        ShowArrayDouble(arrayDouble);
         Console.WriteLine($"Количество введенных чисел больше нуля: {GetAboveZeroDouble(arrayDouble)}");
        // время ожидания до нового запроса в сек.
        WaitSeconds(5);
    };

};


void ShowArrayDouble(double[] array){
    int len = array.Length;
    for (int i = 0; i < len; i++){
        Console.Write($"{array[i]} ");
    };
    Console.WriteLine();
};


int GetAboveZeroDouble(double[] array){
    int count = 0;
    foreach (int i in array){
        if(array[i] > 0.0){
            count++;
        };
    };
    return count;
};


void WaitSeconds(double sec){
    System.Threading.Thread.Sleep((int)(sec * 1000));
};


void ViewTitleTask(string? text = ""){
    Console.Clear();
    Console.WriteLine($"{text}");
    Console.WriteLine($"Для завершения программы, нажмите Ctrl + C");
    Console.WriteLine();
    Console.WriteLine();
};


int ReadIntegerFromString(string write){
    while(true){
        Console.Write($"{write} ");
        string? text = Console.ReadLine();

        if(text != String.Empty){
            return Convert.ToInt32(text);
        }else{
            Console.WriteLine($"Attention: the data is incorrect!!!");
            WaitSeconds(1);
        };
    };    
};


double[] ReadDoubleArrayFromString(string write, char delimiter = ' '){
    char[] charsToTrim = {' '};
    string pattern = @"^((-?\d+,\d+)|(-?\d+))((\s-?\d+,\d+)|(\s-?\d+))+$";
    string[] strNumbers;
    double[] arrayDouble;

    while(true){
        // выводим запрос данных
        Console.Write($"{write}");
        // считываем данные
        string? text = Console.ReadLine()?.Trim(charsToTrim).Replace(".", ",");
        text = text.Replace(", ", " ");

        // проверяем что строка не пуста
        if(text != ""){
            // проверяем данные на соответствие
            if(Regex.IsMatch(text, pattern, RegexOptions.IgnoreCase) ){
                // преобразуем строку в строковой массив
                strNumbers = text.Split(delimiter);

                // конвертируем значения массива в число типа double
                int length = strNumbers.Length;
                arrayDouble = new double[length];

                for(int i = 0; i < strNumbers.Length; i++){
                    arrayDouble[i] = Convert.ToDouble(strNumbers[i]);
                };
                return arrayDouble;
            }else{
                Console.WriteLine($"Attention: the data is incorrect!!!");
                WaitSeconds(1);
            };
        };
    };
};