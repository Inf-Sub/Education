/*
Задача 38:
Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
*/





Run();


void Run(){
    string rn = "\n";
    string title =  
        $"Урок 5. Функции и одномерные массивы.{rn}"+
        $"Задача 38:{rn}"+
        $"Задайте массив вещественных чисел. Найдите разницу между максимальным.{rn}"+
        $"и минимальным элементов массива.{rn}"+
        $"{rn}"+
        $"Вещественные числа — это числа, у которых есть дробная часть. (она может.{rn}"+
        $"быть нулевой). Они могут быть положительными или отрицательными.{rn}"+
        $"{rn}"+
        $"Например:{rn}"+
        $"[3 7 22 2 78] -> 76{rn}"+
        $"{rn}"+
        $"Для завершения программы, нажмите Ctrl + C{rn}";

    int arrLen = 0;
    int arrLenMin = 5;
    int arrLenMax = 15;

    double arrMin = 0;
    double arrMax = 100;
    double[] ArrayRandomDouble;

    double result;

    while(true){
        ViewTitleTask(title);
        WaitSeconds(1);
        
        arrLen = new Random().Next(arrLenMin, arrLenMax + 1);
        ArrayRandomDouble = CreateRandomDoubleArray(arrLen, arrMin, arrMax);
        Console.WriteLine($"Создан рандомный массив из {arrLen} вещественных чисел от {arrMin} до {arrMax}:");
        ShowArrayDouble(ArrayRandomDouble, 3);

        result = getDiffBetweenMaxMinElementsOfArray(ArrayRandomDouble);

        Console.WriteLine($"В созданном массиве - разность минимального и максимально элементов равна: {result:f3}!");

        // время ожидания до обновления массива в сек.
        WaitSeconds(10);
    };

};

// ищем разницу между максимальным элементами массива
double getDiffBetweenMaxMinElementsOfArray(double[] array){
    double min = array[0];
    double max = array[0];
    int len = array.Length;
    for (int i = 1; i < len; i++){
        //Console.WriteLine($"{min} {array[i]} {max}");
        if(min > array[i]){
            min = array[i];
        };
        if(max < array[i]){
            max = array[i];
        };        
    };
    Console.WriteLine($"min: {min:f3}, max: {max:f3}");
    return max - min;
};

// создаем рандомный ммассив вещественных чисел
double[] CreateRandomDoubleArray(int N, double min, double max){
    double[] RandomArray = new double[N];

    for (int i = 0; i < N; i++){
        RandomArray[i] = (new Random().NextDouble() * (max - min) + min);
        //Console.WriteLine($"{RandomArray[i]}");
    };

    return RandomArray;
};


void ShowArrayDouble(double[] array, int format){
    int len = array.Length;
    for (int i = 0; i < len; i++){
        Console.Write($"{array[i]:f3} ");
    };
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


