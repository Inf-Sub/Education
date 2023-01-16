Console.Clear();
Console.WriteLine(
    $"Задача 32: Напишите программу замены элементов\n" +
    $"массива: положительные элементы замените на\n" +
    $"соответствующие отрицательные, и наоборот.\n" +
    $"[-4, -8, 8, 2] -> [4, 8, -8, -2]\n"
);



int[] arr = CreateRandomArray(12, -9, 9);
ShowArray(arr);


for(int i = 0; i < arr.Length; i++){
    arr[i] *= -1;
};

ShowArray(arr);




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