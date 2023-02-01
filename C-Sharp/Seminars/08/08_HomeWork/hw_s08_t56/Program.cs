/*
Задача 56: 
Задайте прямоугольный двумерный массив. Напишите программу, которая 
будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка
*/


Run();


void Run(){
    string rn = "\n";
    string title =  
        $"Урок 8. Двумерные массивы.{rn}"+
        $"Задача 56:{rn}"+
        $"Задайте прямоугольный двумерный массив. Напишите программу, которая{rn}"+
        $"будет находить строку с наименьшей суммой элементов.{rn}"+
        $"{rn}"+
        $"Например, задан массив:{rn}"+
        $"1 4 7 2{rn}"+
        $"5 9 2 3{rn}"+
        $"8 4 2 4{rn}"+
        $"5 2 6 7{rn}"+
        $"Программа считает сумму элементов в каждой строке и выдаёт номер строки{rn}"+
        $"с наименьшей суммой элементов: 1 строка{rn}";
        

    int arrRowLen = 0;
    int arrColLen = 0;
    int arrLenMin = 3;
    int arrLenMax = 10;

    int arrMin = 0;
    int arrMax = 100;
    int[,] ArrayRandomInt;
    int resultStringNumber;


    ViewTitleTask(title);

    while(true){
        Console.Clear();
        
        
        arrRowLen = new Random().Next(arrLenMin, arrLenMax + 1);
        arrColLen = new Random().Next(arrRowLen, arrRowLen * 2 + 1);
        ArrayRandomInt = CreateRandomTwoDimensionalIntArray(arrRowLen, arrColLen, arrMin, arrMax);
        
        Console.WriteLine(
            $"Создан рандомный двумерный массив {arrRowLen} x {arrColLen} "+
            $"чисел от {arrMin} до {arrMax}:"
        );
        ShowArrayTwoDimensionalInt(ArrayRandomInt);
        Console.WriteLine();        
        
        
        resultStringNumber = findSmallSumElementsOnArray(ArrayRandomInt);
              
        Console.WriteLine(
            $"Наименьшая сумма элементов в {resultStringNumber + 1} строке "+
            $"(с индексом {resultStringNumber})"
        );
        Console.WriteLine();

        
        Console.WriteLine($"Press any key to continue...");
        Console.ReadKey();
    };

};


int findSmallSumElementsOnArray(int[,] array){
       int min = 0, sum, findStr = 0;
    int lenRow = array.GetLength(0);
    int lenCol = array.GetLength(1);
    for(int row = 0; row < lenRow; row++){
        sum = 0;
        for(int col = 0; col < lenCol; col++){
            sum += array[row, col];
        };
        if(row == 0 || min > sum){
            min = sum; 
            findStr = row;
        };
        // детализация по поиску
        Console.WriteLine($"row: {row} | sum: {sum} | min: {min} | findStr: {findStr}");
    };
    Console.WriteLine();
    
    return findStr;
};



// создаем рандомный числовой массив 
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

