// create Method (Function) FillArray with random int
void FillArray(int[] collecton)
{
    int len = collecton.Length;
    int index = 0;
    while (index < len)
    {
        collecton[index] = new Random().Next(1, 10);
        index++;
    };
};

// create Method (Function) PrintArray to Console
void PrintArray(int[] array)
{
    int count = array.Length;
    int key = 0;

    Console.Write($"Array: [ ");
    while (key < count)
    {
        Console.Write($"{array[key]} ");
        key++;
    };
    Console.WriteLine($"]");
};

// Method with return
int IndexOf(int[] collection, int find)
{
    int count = collection.Length;
    int index = 0;
    int position = -1;

    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        };
        index++;
    };

    //Console.WriteLine($"{position}");
    return position;
};


Console.Write($"Enter a number from 1 to 9 to search the array: ");
int find = Convert.ToInt32(Console.ReadLine());
// создаем массив на 10 целых чисел
int[] array = new int[10];

FillArray(array);
PrintArray(array);
int pos = IndexOf(array, find);

if (pos >= 0)
{
    Console.WriteLine($"Number: >> {find} << found at position: >> {pos} << of the array");
}
else
{
    Console.WriteLine($"Number: >> {find} << NOT found of the array");
};
