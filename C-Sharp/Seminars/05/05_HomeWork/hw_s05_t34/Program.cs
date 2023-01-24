/*
Урок 5. Функции и одномерные массивы. Задача 34: 
Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/



Run();


void Run(){
    string rn = "\n";
    string title =  
        $"Урок 5. Функции и одномерные массивы. Задача 34:{rn}"+
        $"Задайте массив заполненный случайными положительными трёхзначными числами.{rn}"+
        $"Напишите программу, которая покажет количество чётных чисел в массиве.{rn}"+
        $"{rn}"+
        $"Например:{rn}"+
        $"[345, 897, 568, 234] -> 2{rn}"+
        $"{rn}"+
        $"Для завершения программы, нажмите Ctrl + C{rn}";

    int ArrayLenghtMin = 5;
    int ArrayLenghtMax = 15;
    int NumberMin = 100;
    int NumberMax = 1000;
    int ArrayLenght;
    int[] ArrayRandomInt;
    int result;


    while(true){
        ViewTitleTask(title);
        WaitSeconds(1);

        
        ArrayLenght = new Random().Next(ArrayLenghtMin, ArrayLenghtMax + 1);

        ArrayRandomInt = CreateRandomArray(ArrayLenght, NumberMin, NumberMax);

        Console.WriteLine($"Создан рандомный массив из {ArrayLenght} чисел от {NumberMin} до {NumberMax - 1}:");
        ShowArrayInt(ArrayRandomInt);

        result = NumberOfEvenNumbersInArray(ArrayRandomInt);

        Console.WriteLine($"В созданном массиве - найдено {result} положительных чисел!");

        // время ожидания до обновления массива в сек.
        WaitSeconds(7);
    };

};


int NumberOfEvenNumbersInArray(int[] array){
    int count = 0;
    int len = array.Length;

    for(int i = 0; i < len; i++){
        if(array[i] % 2 == 0)
        {
            count++;
        };
    };

    return count;
};


int[] CreateRandomArray(int N, int start, int end){
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++){
        RandomArray[i] = new Random().Next(start, end + 1);
    };
    return RandomArray;
};


void ShowArrayInt(int[] array){
    for (int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");
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


