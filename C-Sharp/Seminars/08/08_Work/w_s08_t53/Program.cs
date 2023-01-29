/*
Задача 53: Задайте двумерный массив. Напишите программу,
которая поменяет местами первую и последнюю строку
массива.
*/



int arrRowLen = 0;
int arrColLen = 0;
int arrLenMin = 3;
int arrLenMax = 8;

int arrMin = -10000;
int arrMax = 10000;
int[,] ArrayRandomInt;


arrRowLen = new Random().Next(arrLenMin, arrLenMax + 1);
arrColLen = new Random().Next(arrRowLen, arrRowLen * 2 + 1);
ArrayRandomInt = CreateRandomTwoDimensionalIntArray(arrRowLen, arrColLen, arrMin, arrMax);


ShowArrayTwoDimensionalInt(ArrayRandomInt);
replaceArrayFirstAndLastRows(ArrayRandomInt);
ShowArrayTwoDimensionalInt(ArrayRandomInt);

int[,] replaceArrayFirstAndLastRows(int[,] array){
    int lenRow = array.GetLength(0);
    int lenCol = array.GetLength(1);

    int[,] tempArrayFirst = new int[1, lenCol];
    int[,] tempArrayEnd = new int[1, lenCol];
    for(int i = 0; i < lenCol; i++){
        tempArrayFirst[0, i] = array[0, i];
        tempArrayEnd[0, i] = array[lenRow-1, i];
    };
    for(int i = 0; i < lenCol; i++){
        array[0, i] = tempArrayEnd[0, i];
        array[lenRow-1, i] = tempArrayFirst[0, i];
    };
    
    return array;
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
