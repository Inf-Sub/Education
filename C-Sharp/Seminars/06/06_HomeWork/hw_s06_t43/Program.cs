/*
Урок 6. Одномерные массивы. Продолжение
Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
*/


using System.Text.RegularExpressions;



Run();


void Run(){
    Console.Clear();

    string rn = "\n";
    string title =  
        $"Урок 6. Одномерные массивы.{rn}"+
        $"Задача 43:{rn}"+
        $"Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями{rn}"+
        $"y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.{rn}"+
        $"{rn}"+
        $"Например:{rn}"+
        $"b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5){rn}"+
        $"{rn}";

    double[] arrayDouble;
    double b1, k1, b2, k2;
    double[] result = new double[2];

    while(true){
        ViewTitleTask(title);
        WaitSeconds(1);

        arrayDouble = ReadDoubleArrayFromString($"Вводите через пробел значения переменных b1, k1, b2 и k2:");
        //ShowArrayDouble(arrayDouble);

        b1 = arrayDouble[0];
        k1 = arrayDouble[1];
        b2 = arrayDouble[2];
        k2 = arrayDouble[3];

        // если нет ошибок, выводим координаты пересечения прямых
        if(GetPoint(result, b1, k1, b2, k2)){
            Console.WriteLine(String.Join(" ", result));
        };
        
        // время ожидания до нового запроса в сек.
        WaitSeconds(5);
    };

};


bool GetPoint(double[] result, double B1, double K1, double B2, double K2){
    if(B1 == B2 && K1 == K2){
        Console.WriteLine("Прямая лежит на прямой!");
        return false;
    }else if(K1 == K2){
        Console.WriteLine("Прямые параллельны!");
        return false;
    };
    result[0] = (B2 - B1) / (K1 - K2);  // x
    Console.WriteLine($"{(B2 - B1)} / {(K1 - K2)} = {result[0]}");
    result[1] = K1 * result[0] + B1;    // y
    return true;
};


void ShowArrayDouble(double[] array){
    int len = array.Length;
    for (int i = 0; i < len; i++){
        Console.Write($"{array[i]} ");
    };
    Console.WriteLine();
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