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
        $"Для звавершения программы, нажмите Ctrl + C{rn}";

    int ArrayLenghtMin = 5;
    int ArrayLenghtMax = 15;
    int ArrayLenght;
    int[] ArrayRandomInt;
    int result;


    while(true){
        ViewTitleTask(title);
        WaitSeconds(1);

        
        ArrayLenght = new Random().Next(ArrayLenghtMin, ArrayLenghtMax + 1);

        ArrayRandomInt = CreateRandomArray(ArrayLenght, 100, 999);

        Console.WriteLine($"Рандомный массив из {ArrayLenght} чисел от {ArrayLenghtMin} до {ArrayLenghtMax}:");
        ShowArrayInt(ArrayRandomInt);

        result = NumberOfEvenNumbersInArray(ArrayRandomInt);

        Console.WriteLine($"Найдено {result} положительных чисел в массиве!");


        WaitSeconds(5);
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


