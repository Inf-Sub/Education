/*
Урок 8. Двумерные массивы. Продолжение
Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/


Run();


void Run(){
    string rn = "\n";
    string title =  
        $"Урок 8. Двумерные массивы.{rn}"+
        $"Задача 54:{rn}"+
        $"Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию.{rn}"+
        $"элементы каждой строки двумерного массива.{rn}"+
        $"{rn}"+
        $"Например, задан массив:{rn}"+
        $"1 4 7 2{rn}"+
        $"5 9 2 3{rn}"+
        $"8 4 2 4{rn}"+
        $"В итоге получается вот такой массив:{rn}"+
        $"7 4 2 1{rn}"+
        $"9 5 3 2{rn}"+
        $"8 4 4 2{rn}"+
        $"{rn}"+
        $"Для завершения программы, нажмите Ctrl + C{rn}";

    int arrRowLen = 0;
    int arrColLen = 0;
    int arrLenMin = 3;
    int arrLenMax = 10;

    int arrMin = 0;
    int arrMax = 100;
    int[,] ArrayRandomInt;
    int[,] resultArray;


    while(true){
        ViewTitleTask(title);
        WaitSeconds(1);
        
        arrRowLen = new Random().Next(arrLenMin, arrLenMax + 1);
        arrColLen = new Random().Next(arrRowLen, arrRowLen * 2 + 1);
        ArrayRandomInt = CreateRandomTwoDimensionalIntArray(arrRowLen, arrColLen, arrMin, arrMax);
        
        Console.WriteLine($"Создан рандомный двумерный массив {arrRowLen}x{arrColLen} вещественных чисел от {arrMin} до {arrMax}:");
        ShowArrayTwoDimensionalInt(ArrayRandomInt);
        Console.WriteLine();        
        
        resultArray = SortMaxToMinArray(ArrayRandomInt);
        
        ShowArrayTwoDimensionalInt(resultArray);
        Console.WriteLine();

        // время ожидания до обновления массива в сек.
        WaitSeconds(10);
    };

};


int[,] SortMaxToMinArray(int[,] array){
    int min, max, temp;
    int lenRow = array.GetLength(0);
    int lenCol = array.GetLength(1);
    //int[,] result = new int[lenCol, lenRow];
    
    Console.WriteLine($"lenRow: {lenRow} lenCol: {lenCol} ");

    for(int row = 0; row < lenRow; row++){ 
        //Console.WriteLine($"row {row}");
        for(int i= 0; i < lenCol-1; i++){
            //Console.WriteLine($"i {i}");
            for(int col = 1, prev = 0; col < lenCol; col++, prev++){
                //Console.WriteLine($"prev {prev}/{lenCol}");
                max = array[row, prev];
                min = array[row, col];
                //Console.Write($"= max: {max}, min: {min} | ");

                if(max < min){
                    array[row, prev] = min; // max
                    array[row, col] = max;  // min
                    //Console.Write($"= min: {min}, max: {max} | ");
                };
                //Console.Write($"{array[row, prev]} >> ");
            };
            //Console.WriteLine();
        };
        //Console.WriteLine();
    };

    return array;
};


// создаем рандомный ммассив вещественных чисел
int[,] CreateRandomTwoDimensionalIntArray(int row, int col, int min, int max){
    int[,] RandomArray = new int[row, col];

    for (int i = 0; i < row; i++){
        for (int j = 0; j < col; j++){
            RandomArray[i, j] = new Random().Next(min, max + 1);
            //Console.WriteLine($"{RandomArray[i, j]}");
        };
    };

    return RandomArray;
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


void ShowArrayTwoDimensionalInt(int[,] array){
    int lenRow = array.GetLength(0);
    int lenCol = array.GetLength(1);
    for (int i = 0; i < lenRow; i++){
        for (int j = 0; j < lenCol; j++){
            Console.Write($"| {array[i, j]}\t");
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


int[] ReadIntegerArrayFromString(string write){
    char[] charsToTrim = {' '};

    while(true){
        Console.Write($"{write} ");
        // считываем данные
        string? text = Console.ReadLine()?.Trim(charsToTrim);

        if(text != String.Empty){            
            string[] strArr = text.Split(',', '.', ' ');
            int len = strArr.Length;
            int[] intArr = new int[len];
            for(int i = 0; i < len; i++){
                intArr[i] = Convert.ToInt32(strArr[i]);
            };

            return intArr;
        }else{
            Console.WriteLine($"Attention: the data is incorrect!!!");
            WaitSeconds(1);
        };
    };    
};

