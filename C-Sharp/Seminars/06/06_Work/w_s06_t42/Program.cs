/*

//Задача 42. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

*/



int num = new Random().Next(1, 1000);
num = 856;
int result = from10to2(num);

Console.WriteLine($"num: {num} -> result: {result}");


int from10to2(int num){
    string result = String.Empty;
    while(num > 0){
        Console.Write($"num: {num} / 2 = ");
        result = (num % 2).ToString() + result;
        num /= 2;
        Console.WriteLine($"{num} result: {result}; ");
    };
    return Convert.ToInt32(result);
};




// решение зала:


/* //Задача 42. Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10
 */


//Console.Clear();

//Console.WriteLine();
//Console.Write($"Введите число в десятичном формате для преобразование в двоичное: ");
int N = num;
//int N = Convert.ToInt32(Console.ReadLine());
int[] Array = CreateRandomArray(Convert.ToInt32(Math.Log2(N))+1, 0, 0);
int i = 0;
//Console.WriteLine($"{Convert.ToInt32(Math.Log2(N))} {Convert.ToInt32(Math.Log2(N))+1}");
ShowArray(Array);
while (N > 0)
{
    Array[Array.Length-i-1] = N % 2;
    Console.Write($"i: {i} N: {N} / 2 = ");
    N = N/2;
    Console.WriteLine($"{N} result: {Array[Array.Length-i-1]}");
    i++;
}
ShowArray(Array);



int[] CreateRandomArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
};
void ShowArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
};

