/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/





Run();


void Run(){
    string rn = "\n";
    string title =  
        $"Задача 36:{rn}"+
        $"Задайте одномерный массив, заполненный случайными числами.{rn}"+
        $"Найдите сумму элементов, стоящих на нечётных позициях.{rn}"+
        $"{rn}"+
        $"Например:{rn}"+
        $"[3, 7, 23, 12] -> 19{rn}"+
        $"[-4, -6, 89, 6] -> 0{rn}"+
        $"{rn}"+
        $"Для завершения программы, нажмите Ctrl + C{rn}";

    int ArrayLenghtMin = 5;
    int ArrayLenghtMax = 10;
    int NumberMin = -99;
    int NumberMax = 99;
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

        //result = NumberOfEvenNumbersInArray(ArrayRandomInt);
        result = SumOfElementsInOddPositions(ArrayRandomInt);

        Console.WriteLine($"В созданном массиве - сумма нечетных элементов равна: {result}!");

        // время ожидания до обновления массива в сек.
        WaitSeconds(10);
    };

};


int SumOfElementsInOddPositions(int[] array){
    int sum = 0;
    int len = array.Length;

    for(int i = 1; i < len; i += 2){
        sum += array[i];
    };

    return sum;
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


