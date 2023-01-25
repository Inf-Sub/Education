/* 
Урок 7. Двумерные массивы
Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
*/


Run();


void Run(){
    string rn = "\n";
    string title =  
        $"Урок 7. Двумерные массивы.{rn}"+
        $"Задача 52:{rn}"+
        $"Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.{rn}"+
        $"{rn}"+
        $"Например:{rn}"+
        $"1 4 7 2{rn}"+
        $"5 9 2 3{rn}"+
        $"8 4 2 4{rn}"+
        $"Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.{rn}"+
        $"{rn}"+
        $"Для завершения программы, нажмите Ctrl + C{rn}";

    int arrRowLen = 0;
    int arrColLen = 0;
    int arrLenMin = 3;
    int arrLenMax = 8;

    int arrMin = -100;
    int arrMax = 100;
    int[,] ArrayRandomInt;
    int rowLen;
    int colLen;
    double sum;
    double average;


    while(true){
        ViewTitleTask(title);
        WaitSeconds(1);
        
        arrRowLen = new Random().Next(arrLenMin, arrLenMax + 1);
        arrColLen = new Random().Next(arrRowLen, arrRowLen * 2 + 1);
        ArrayRandomInt = CreateRandomTwoDimensionalIntArray(arrRowLen, arrColLen, arrMin, arrMax);
        
        Console.WriteLine($"Создан рандомный двумерный массив {arrRowLen}x{arrColLen} вещественных чисел от {arrMin} до {arrMax}:");
        ShowArrayTwoDimensionalInt(ArrayRandomInt);
        Console.WriteLine();
        
        
        rowLen = ArrayRandomInt.GetLength(0);
        colLen = ArrayRandomInt.GetLength(1);

        //Console.WriteLine($"Расчет:");
        for(int c = 0; c < colLen; c++){
            sum = 0;
            for(int r = 0; r < rowLen; r++){
                sum += ArrayRandomInt[r, c];
                //if(r != 0){Console.Write($"+");};
                //Console.Write($" {ArrayRandomInt[r, c]}\t");
            };
            average = sum / rowLen;
            //Console.WriteLine($"= {sum}\t/ {rowLen}\t= {average}");
            Console.WriteLine($"Среднее арифметическое {c} столбца: {average:f3}");
        };



        Console.WriteLine();

        // время ожидания до обновления массива в сек.
        WaitSeconds(10);
    };

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
            Console.Write($"|  {array[i, j]}\t");
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




