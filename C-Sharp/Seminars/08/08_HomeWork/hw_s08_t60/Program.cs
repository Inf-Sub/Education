/*
Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/



Run();


void Run(){
    string rn = "\n";
    string title =  
        $"Урок 8. Двумерные массивы.{rn}"+
        $"Задача 60:{rn}"+
        $"Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.{rn}"+
        $"Напишите программу, которая будет построчно выводить массив, добавляя{rn}"+
        $"индексы каждого элемента.{rn}"+
        $"{rn}"+
        $"Массив размером 2 x 2 x 2{rn}"+
        $"66(0,0,0) 25(0,1,0){rn}"+
        $"34(1,0,0) 41(1,1,0){rn}"+
        $"27(0,0,1) 90(0,1,1){rn}"+
        $"26(1,0,1) 55(1,1,1){rn}";
        
    // длина каждой метрики массива
    int arrXLen;
    int arrYLen;
    int arrZLen;

    // ограничение длины массива
    int arrLenMin = 3;
    int arrLenMax = 5;

    // диапазон чисел в массиве
    int arrMin = 10;
    int arrMax = 99;

    int[,,] ArrayRandomInt;
    int resultStringNumber;


    ViewTitleTask(title);

    while(true){
        Console.Clear();
        
        // длина каждой метрики массива
        arrXLen = new Random().Next(arrLenMin, arrLenMax + 1);
        arrYLen = new Random().Next(arrLenMin, arrLenMax + 1);
        // для лучшего представления в терминале количество столбцов удваеваем по сравнению с количеством строк
        arrZLen = new Random().Next(arrYLen, arrYLen * 2 + 1);

        // или задайте вручную:
        // arrXLen = 2;
        // arrYLen = 2;
        // arrZLen = 2;

        // проверка значений на соответствие условию задачи
        if(!CheckUniqueParamsForArray(arrXLen, arrYLen, arrZLen, arrMin, arrMax)){
            continue;
        };
        // создание массива
        ArrayRandomInt = CreateRandom3DUniqueIntArray(arrXLen, arrYLen, arrZLen, arrMin, arrMax);
        
        Console.WriteLine($"{rn}Создан рандомный двумерный массив {arrXLen} x {arrYLen} x {arrZLen} "+
        $"чисел от {arrMin} до {arrMax}:{rn}");
        WaitSeconds(1);
        
        // ыфводим созданный массив в консоль (для проверки и сравнения)
        ShowArray3DInt(ArrayRandomInt);
        Console.WriteLine();
        WaitSeconds(1);

        // построчно выводим массив, добавляя индексы каждого элемента
        ShowArray3DInt(ArrayRandomInt, true);

        // время ожидания до обновления массива в сек.
        //WaitSeconds(10);
        
        Console.WriteLine($"Press any key to continue...");
        Console.ReadKey();
    };
};


bool CheckUniqueParamsForArray(int lenX, int lenY, int lenZ, int min, int max){
    bool result = true;
    string rn = "\n";
    if(max - min < lenX * lenY * lenZ){
        Console.WriteLine(
            $"Упс... Кажется промашка вышла...))){rn+rn}"+
            $"При заданных значениях минимального ({min}) и максильного ({max}) чисел,{rn}"+
            $"невозможно создать 3D массив заданных рахмеров: {lenX} x {lenY} x {lenZ},{rn}"+
            $"так как количество рандомно созданных чисел ({max - min}), меньше количества{rn}"+
            $"ячеек в массиве ({lenX * lenY * lenZ})"
        );
        WaitSeconds(1);
        result = false;
    };
    return result;
};


// создаем рандомный числовой 3D массив
int[,,] CreateRandom3DUniqueIntArray(int lenX, int lenY, int lenZ, int min, int max){
    int[,,] RandomArray = new int[lenX, lenY, lenZ];
    int randNumber;
    string cache = " ";

    for (int x = 0; x < lenX; x++){
        for (int y = 0; y < lenY; y++){
            for (int z = 0; z < lenZ; z++){
                // зацикливаем создание рандомного числа, для получения уникального значения
                while(true){
                    randNumber = new Random().Next(min, max + 1);
                    // проверяем в кэше было ли число ранее (числа разделены пробелами)
                    if(!cache.Contains(" " + randNumber.ToString() + " ")){
                        // если число уникально, записываем в массив
                        RandomArray[x, y, z] = randNumber;
                        // добавляем число в кэш
                        cache += randNumber + " ";
                        // прерываем цикл while
                        break;
                    };
                };
            };
            //Console.WriteLine($"{RandomArray[x, y, z]}");
        };
    };

    return RandomArray;
};


void ShowArray3DInt(int[,,] array, bool showCord = false){
    int lenX = array.GetLength(0);
    int lenY = array.GetLength(1);
    int lenZ = array.GetLength(2);
    string newLine = new string('-', lenZ * ((showCord) ? 16 : 8) + 1);

    Console.WriteLine($"{newLine}");  
    for (int x = 0; x < lenX; x++){
        for (int y = 0; y < lenY; y++){
            for (int z = 0; z < lenZ; z++){
                Console.Write(
                    $"| {array[x, y, z]}"+
                    ((showCord) ? $" ({x},{y},{z})" : $"{String.Empty}" ) +
                    $"\t"
                );
            };
            Console.WriteLine("|");
        };
        Console.WriteLine($"{newLine}");        
    };
    Console.WriteLine();
};


void WaitSeconds(double sec){
    System.Threading.Thread.Sleep((int)(sec * 1000));
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

