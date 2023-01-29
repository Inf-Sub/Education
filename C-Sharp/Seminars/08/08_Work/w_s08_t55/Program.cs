/*
Задача 55: Задайте двумерный массив. Напишите программу,
которая заменяет строки на столбцы. В случае, если это
невозможно, программа должна вывести сообщение для
пользователя.
*/


int arrLen = 0;
int arrLenMin = 3;
int arrLenMax = 8;

int arrMin = -10000;
int arrMax = 10000;
int[,] ArrayRandomInt;


arrLen = new Random().Next(arrLenMin, arrLenMax + 1);
ArrayRandomInt = CreateRandomTwoDimensionalIntArray(arrLen, arrLen, arrMin, arrMax);


ShowArrayTwoDimensionalInt(ArrayRandomInt);
//ArrayRandomInt = replaceArrayRowToCol(ArrayRandomInt);
ArrayRandomInt = ReversRowColArray2D(ArrayRandomInt);
ShowArrayTwoDimensionalInt(ArrayRandomInt);

/*
int[,] replaceArrayRowToCol(int[,] array){
    int arrLen = array.GetLength(0);

    int[,] tempArray = array;
    
    for(int i = 0; i < arrLen; i++){
        for(int j = 0; j < arrLen; j++){
            array[i, j] = tempArray[j, i];
            //Console.Write($" {array[j, i]} ");
        };
        // Console.WriteLine($"");
    };
    
    return array;
};
*/


int[,] ReversRowColArray2D(int[,] arr){
    int[,] newArr = new int[arr.GetLength(0), arr.GetLength(1)];
    for (int i = 0; i < arr.GetLength(0); i++){
        for (int j = 0; j < arr.GetLength(1); j++){
            newArr[j, i] = arr[i, j];
        };
    };
    return newArr;
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
