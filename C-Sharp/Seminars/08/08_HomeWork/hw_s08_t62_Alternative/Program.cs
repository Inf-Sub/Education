/*
Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/




Run();



void Run(){
    string rn = "\n";
    string title =  
        $"Урок 8. Двумерные массивы.{rn}"+
        $"Задача 62:{rn}"+
        $"Напишите программу, которая заполнит спирально массив 4 на 4.{rn}"+
        $"Например, на выходе получается вот такой массив:{rn}"+
        $"{rn}"+
        $"01 02 03 04{rn}"+
        $"12 13 14 05{rn}"+
        $"11 16 15 06{rn}"+
        $"10 09 08 07{rn}";
        
    // длина каждой метрики массива
    int arrLen;

    // ограничение длины массива
    int arrLenMin = 1;
    int arrLenMax = 10;

    int[,] ArrayRandomInt;


    ViewTitleTask(title);

    while(true){
        Console.Clear();
        

        arrLen = new Random().Next(arrLenMin, arrLenMax + 1);

        ArrayRandomInt = new int[arrLen, arrLen];

        MatrixSpiralAlternative(ArrayRandomInt);

        Console.WriteLine($"Создана матрица размером {arrLen} x {arrLen}:");
        ShowArrayTwoDimensionalInt(ArrayRandomInt);
        Console.WriteLine(); 
       
        
        
        Console.WriteLine($"Press any key to continue...");
        Console.ReadKey();
    };

};


// alternative method name: Anaconda
void MatrixSpiralAlternative(int[,] array){
    int len = array.GetLength(0);

    // во избежание деления на 0
    if(len == 1){
        array[0, 0] = 1;
        return;
    };

    for (int row = 0; row < len; row++){
        for (int col = 0; col < len; col++){
            int i = row + 1;     // Номера строк и столбцов приводим в удобный
            int j = col + 1;     // в математическом плане вид (от 1 до len)  
            
            // основной код вычислений
            int switcher =  (j - i + len) / len;
            int CntrI = Math.Abs(i - len / 2  - 1) + (i - 1)/(len /2) * ((len-1) % 2);
            int CntrJ = Math.Abs(j - len / 2  - 1) + (j - 1)/(len /2) * ((len-1) % 2);
            int Ring = len / 2 - (Math.Abs(CntrI - CntrJ) + CntrI + CntrJ) / 2;
            int RingLen = i - Ring + j - Ring - 1;    
            int Coefficient = 4 * Ring * (len - Ring);
            array[row, col] = Coefficient + switcher * RingLen + Math.Abs(switcher - 1) * (4 * (len - 2 * Ring) - 2 - RingLen);
        };
    };
};


void ShowArrayTwoDimensionalInt(int[,] array){
    int lenRow = array.GetLength(0);
    int lenCol = array.GetLength(1);
    string newLine = new string('-', lenCol * 8 + 1);

    Console.WriteLine($"{newLine}");
    for (int i = 0; i < lenRow; i++){
        for (int j = 0; j < lenCol; j++){
            Console.Write($"| ");
            Console.Write("{0:d2} ", array[i, j]);
            Console.Write($"\t");
        };
        Console.WriteLine("|");
    };
    Console.WriteLine($"{newLine}");
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

