Console.Clear();
Console.WriteLine(
    $"Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9].\n{Stroke.}" +
    $"Найдите сумму отрицательных и положительных элементов массива.\n" +
    $"Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29,\n" +
    $"сумма отрицательных равна -20."
);

int[] arr = CreateRandomArray(12, -9, 9);
ShowArray(arr);

int positive = 0;
int negative = 0;

for(int i = 0; i < arr.Length; i++){
    if(arr[i] > 0){
        positive += arr[i];
    }else{
        negative += arr[i];
    };
};

Console.WriteLine($"Summ positive  = {positive}");
Console.WriteLine($"Summ negative  = {negative}");




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