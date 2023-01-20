/*
//Задача 45. Напишите программу, которая будет создавать копию заданного
//массива с помощью поэлементного копирования.
*/


//Напишите программу, которая будет создавать копию 
//заданного массива с помощью поэлементного копирования.
Clear();

int[] array = GetArray(10, 0, 10);
WriteLine(String.Join(" ", array));

int[] copyArray=CopyArray(array);
WriteLine(String.Join(" ", copyArray));


int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];

    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int[] CopyArray(int[] inArray)
{
    int[] result = new int[inArray.Length];
    for (int i = 0; i < inArray.Length; i++)
    {
        result[i] = inArray[i];

    }
    return result;
}