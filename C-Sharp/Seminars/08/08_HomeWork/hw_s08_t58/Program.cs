/*
Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18
*/


Run();


void Run(){
    string rn = "\n";
    string title =  
        $"Урок 8. Двумерные массивы.{rn}"+
        $"Задача 58:{rn}"+
        $"Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.{rn}"+
        $"Например, даны 2 матрицы:{rn}"+
        $"{rn}"+
        $"Например, задан массив:{rn}"+
        $"2 4 | 3 4{rn}"+
        $"3 2 | 3 3{rn}"+
        $"Результирующая матрица будет:{rn}"+
        $"18 20{rn}"+
        $"15 18{rn}";
        

    int arrRowLen = 0;
    int arrColLen = 0;
    int arrLenMin = 2;
    int arrLenMax = 5;

    int arrMin = 0;
    int arrMax = 100;
    int[,] MatrixA;
    int[,] MatrixB;
    int[,] MatrixResult;


    ViewTitleTask(title);

    while(true){
        Console.Clear();
        
        // MatrixA
        arrRowLen = new Random().Next(arrLenMin, arrLenMax + 1);
        arrColLen = new Random().Next(arrLenMin, arrLenMax + 1);
        MatrixA = CreateRandomTwoDimensionalIntArray(arrRowLen, arrColLen, arrMin, arrMax);

        Console.WriteLine($"Создана матрица 'А': {arrRowLen} x {arrColLen} из чисел от {arrMin} до {arrMax}:");
        ShowArrayTwoDimensionalInt(MatrixA);
        Console.WriteLine(); 

        // MatrixB
        arrRowLen = arrColLen;
        arrColLen = new Random().Next(arrLenMin, arrLenMax + 1);
        MatrixB = CreateRandomTwoDimensionalIntArray(arrRowLen, arrColLen, arrMin, arrMax);

        
        Console.WriteLine($"Создана матрица 'B': {arrRowLen} x {arrColLen} из чисел от {arrMin} до {arrMax}:");
        ShowArrayTwoDimensionalInt(MatrixB);
        Console.WriteLine();        

        
        MatrixResult = MatrixMultiplication(MatrixA, MatrixB);
        

        // тестовые массивы из примера в задаче:
        // int[,] arrA = new [,]{ { 2, 4 }, { 3, 2 } };
        // int[,] arrB = new [,]{ { 3, 4 }, { 3, 3 } };        
        // MatrixResult = MatrixMultiplication(arrA, arrB);


        Console.WriteLine($"Результирующая матрица:");
        ShowArrayTwoDimensionalInt(MatrixResult);
        Console.WriteLine();        


        Console.WriteLine($"Press any key to continue...");
        Console.ReadKey();
    };

};


int[,] MatrixMultiplication(int[,] ArrayA, int[,] ArrayB){
    int lenRowA = ArrayA.GetLength(0);
    int lenColA = ArrayA.GetLength(1);
    int lenRowB = ArrayB.GetLength(0);
    int lenColB = ArrayB.GetLength(1);
    int[,] MultiMatrix = new int[lenRowA, lenColB];
    int rowA, colA, rowB, colB;

    for(rowA = 0; rowA < lenRowA; rowA++){
        for(colA = 0, rowB = 0; colA < lenColA; colA++, rowB++){
            for(colB = 0; colB < lenColB && rowB < lenRowB; colB++){
                // отображение промежуточного этапа вычисления (перемножения элементов матриц)
                //Console.Write($"| {ArrayA[rowA, colA]} * {ArrayB[rowB, colB]}\t");
                MultiMatrix[rowA, colB] += ArrayA[rowA, colA] * ArrayB[rowB, colB];
            };
            //Console.WriteLine($"|");
        };
        //Console.WriteLine($"");
    };
    return MultiMatrix;
};


// создаем рандомный массив вещественных чисел
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