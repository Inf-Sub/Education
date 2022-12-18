int [] array = {43, 23, 33, 54, 58, 115, 33, 78, 34};

int len = array.Length;
int find = 33;

int index = 0;

while(index < len)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    };
    index++;
};