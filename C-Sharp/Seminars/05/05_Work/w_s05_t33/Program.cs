Console.Clear();
Console.WriteLine(
    $"Задача 33:\n" +
    $"Задайте массив. Напишите программу, которая\n" +
    $"определяет, присутствует ли заданное число в массиве.\n" +
    $"4; массив [6, 7, 19, 345, 3] -> нет\n" +
    $"-3; массив [6, 7, 19, 345, 3] -> да\n"
);


Console.Write("Введите искомое число:");
int integer = Convert.ToInt32(Console.ReadLine());

Console.Clear();

int[] arr = CreateRandomArray(1000, -10000, 10000);
ShowArray(arr);
Console.WriteLine();


FoundNumberInArray(arr, integer);

ShowArray(arr);
Console.WriteLine();



void FoundNumberInArray(int[] array, int foundNumber){
    bool found = false;
    for(int i = 0; i < arr.Length; i++){
        if(arr[i] == foundNumber){
            found = true;
            break;
            ;
        };
    };
    Console.WriteLine((found) ? "да" : "нет");
};


int[] CreateRandomArray(int N, int start, int end){
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++){
        RandomArray[i] = new Random().Next(start, end + 1);
    };
    return RandomArray;
};

void ShowArray(int[] array){
    for (int i = 0; i < array.Length; i++){
        Console.Write(array[i] + " ");
    };
    Console.WriteLine();
};