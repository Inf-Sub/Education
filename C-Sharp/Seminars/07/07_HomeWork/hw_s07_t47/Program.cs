/*
Урок 7. Двумерные массивы
Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

m = 3, n = 4
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

Run();


void Run(){
    string rn = "\n";
    string title =  
        $"Урок 7. Двумерные массивы.{rn}"+
        $"Задача 47:{rn}"+
        $"Задайте двумерный массив размером m*n, заполненный случайными вещественными числами.{rn}"+
        $"{rn}"+
        $"Вещественные числа — это числа, у которых есть дробная часть. (она может.{rn}"+
        $"быть нулевой). Они могут быть положительными или отрицательными.{rn}"+
        $"{rn}"+
        $"Например:{rn}"+
        $"m = 3, n = 4{rn}"+
        $"0,5 7 -2 -0,2{rn}"+
        $"1 -3,3 8 -9,9{rn}"+
        $"8 7,8 -7,1 9{rn}"+
        $"{rn}"+
        $"Для завершения программы, нажмите Ctrl + C{rn}";

    int arrRowLen = 0;
    int arrColLen = 0;
    int arrLenMin = 5;
    int arrLenMax = 10;

    double arrMin = -100;
    double arrMax = 100;
    double[,] ArrayRandomDouble;


    while(true){
        ViewTitleTask(title);
        WaitSeconds(1);
        
        arrRowLen = new Random().Next(arrLenMin, arrLenMax + 1);
        arrColLen = new Random().Next(arrLenMin, arrLenMax + 1);
        ArrayRandomDouble = CreateRandomTwoDimensionalDoubleArray(arrRowLen, arrColLen, arrMin, arrMax);
        Console.WriteLine($"Создан рандомный двумерный массив {arrRowLen}x{arrColLen} вещественных чисел от {arrMin} до {arrMax}:");
        ShowArrayTwoDimensionalDouble(ArrayRandomDouble);

        // время ожидания до обновления массива в сек.
        WaitSeconds(10);
    };

};


// создаем рандомный ммассив вещественных чисел
double[,] CreateRandomTwoDimensionalDoubleArray(int row, int col, double min, double max){
    double[,] RandomArray = new double[row, col];

    for (int i = 0; i < row; i++){
        for (int j = 0; j < col; j++){
            RandomArray[i, j] = (new Random().NextDouble() * (max - min) + min);
            //Console.WriteLine($"{RandomArray[i, j]}");
        };
    };

    return RandomArray;
};


void ShowArrayTwoDimensionalDouble(double[,] array){
    int lenRow = array.GetLength(0);
    int lenCol = array.GetLength(1);
    for (int i = 0; i < lenRow; i++){
        for (int j = 0; j < lenCol; j++){
            Console.Write($"| {array[i, j]:f1}\t");
        };
        Console.WriteLine("|");
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


