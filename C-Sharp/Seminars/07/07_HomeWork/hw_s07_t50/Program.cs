/*
Урок 7. Двумерные массивы
Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
и возвращает значение этого элемента или же указание, что такого элемента нет.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

Run();


void Run(){
    string rn = "\n";
    string title =  
        $"Урок 7. Двумерные массивы.{rn}"+
        $"Задача 50:{rn}"+
        $"Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,{rn}"+
        $"и возвращает значение этого элемента или же указание, что такого элемента нет.{rn}"+
        $"{rn}"+
        $"Например:{rn}"+
        $"1 4 7 2{rn}"+
        $"5 9 2 3{rn}"+
        $"8 4 2 4{rn}"+
        $"17 -> такого числа в массиве нет{rn}"+
        $"{rn}"+
        $"Для завершения программы, нажмите Ctrl + C{rn}";

    int arrRowLen = 0;
    int arrColLen = 0;
    int arrLenMin = 3;
    int arrLenMax = 8;

    int arrMin = -100;
    int arrMax = 100;
    int[,] ArrayRandomInt;
    int[] foundXY = new int[2];
    int found;

    while(true){
        ViewTitleTask(title);
        WaitSeconds(1);
        
        arrRowLen = new Random().Next(arrLenMin, arrLenMax + 1);
        arrColLen = new Random().Next(arrRowLen, arrRowLen * 2 + 1);
        ArrayRandomInt = CreateRandomTwoDimensionalIntArray(arrRowLen, arrColLen, arrMin, arrMax);
        
        Console.WriteLine($"Создан рандомный двумерный массив {arrRowLen}x{arrColLen} вещественных чисел от {arrMin} до {arrMax}:");
        ShowArrayTwoDimensionalInt(ArrayRandomInt);
        

        // Вариант 1: по координатам в массиве (x,y)
        Console.WriteLine($"Вариант 1: по координатам в массиве (x,y)");
        foundXY = ReadIntegerArrayFromString($"Введите координаты элемента в двумерном массиве через пробел:");

        if(foundXY[0] > arrRowLen || foundXY[1] > arrColLen){
            Console.WriteLine($"Числа с такими координатами в массиве нет");
        }else{
            Console.WriteLine($"Искомое число: {ArrayRandomInt[foundXY[0]-1, foundXY[1]-1]}");
        };
        Console.WriteLine();

        
        // Вариант 2: по номеру в массиве
        Console.WriteLine($"Вариант 2: по номеру в массиве, длиной: {ArrayRandomInt.Length}");
        found = ReadIntegerFromString($"Введите номер позиции элемента в двумерном массиве (нумерация с 0):");
        

        if(found < ArrayRandomInt.Length){
            Console.WriteLine(
                $"Искомое число: "+
                $"{ArrayRandomInt[found / ArrayRandomInt.GetLength(1), found % ArrayRandomInt.GetLength(1)]}"
            );

        }else{
            Console.WriteLine($"Числа с такой позицией в массиве нет");
        };
        Console.WriteLine();




        // время ожидания до обновления массива в сек.
        WaitSeconds(5);
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




