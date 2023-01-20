// Задача 39. Напишите программу, которая перевернёт одномерный массив 
//(последний элемент будет на первом месте, а первый - на последнем и т.д.)
// [1 2 3 4 5] -> [5 4 3 2 1]
//[6 7 3 6] -> [6 3 7 6]


int[] MyArray = CreateRandomArray(15, 1, 1000);


ShowArray(MyArray);

int len =  MyArray.Length;
int j = len - 1;
int temp;

for(int i = 0; i < len / 2; i++, j--){
    temp = MyArray[i];
    MyArray[i] = MyArray[j];
    MyArray[j] = temp;
};

ShowArray(MyArray);

/*
int[] massive = CreateRandomArray(10, 0, 500);
ShowArray(massive);
for (int i = 0; i < massive.Length / 2; i++)
{
    int temp = massive[i];
    massive[i] = massive[massive.Length - 1 - i];
    massive[massive.Length - 1 - i] = temp;
}
ShowArray(massive);
*/




void ShowArray(int[] array){
    var result = "";
    foreach(var item in array){
        result += item + " ";
    };
    Console.WriteLine($"[ {result}]");
};


int[] CreateRandomArray(int N, int start, int end){
    int[] RandomArray = new int[N];
    for (int i = 0; i < N; i++){
        RandomArray[i] = new Random().Next(start, end + 1);
    };
    return RandomArray;
};