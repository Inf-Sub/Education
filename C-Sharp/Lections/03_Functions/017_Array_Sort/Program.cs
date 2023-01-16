int[] arr = { 1, 5, 4, 7, 3, 2, 6, 7, 1, 1 };


PrintArray(arr);
SelectionSortMinToMax(arr);
PrintArray(arr);
SelectionSortMaxToMin(arr);
PrintArray(arr);



void PrintArray(int[] array){
    int length = array.Length;

    for(int i = 0; i < length; i++){
        Console.Write($"{array[i]} ");
    };

    Console.WriteLine();
};

void SelectionSortMinToMax(int[] array){
    int length = array.Length;
    int minPosition;
    int temporary;

    for(int i = 0; i < length - 1; i++){
        minPosition = i;

        for(int j = i + 1; j < length; j++){
            if(array[j] < array[minPosition]){
                minPosition = j;
            };
        };

        temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    };
};

void SelectionSortMaxToMin(int[] array){
    int length = array.Length;
    int maxPosition;
    int temporary;

    for(int i = 0; i < length - 1; i++){
        maxPosition = i;

        for(int j = i + 1; j < length; j++){
            if(array[j] > array[maxPosition]){
                maxPosition = j;
            };
        };

        temporary = array[i];
        array[i] = array[maxPosition];
        array[maxPosition] = temporary;
    };
};
