/*
Задача №18.
Напишите программу, которая по заданному номеру
четверти, показывает диапазон возможных координат
точек в этой четверти (x и y).
*/



// процедура
void PrintCord(int quarter){
    switch(quarter){
        case 1:
            Console.WriteLine($"Координаты от x > 0 и y > 0 в четверти {quarter}");
            break;

        case 2:
            Console.WriteLine($"Координаты от x < 0 и y > 0 в четверти {quarter}");
            break;

        case 3:
            Console.WriteLine($"Координаты от x < 0 и y < 0 в четверти {quarter}");
            break;

        case 4:
            Console.WriteLine($"Координаты от x > 0 и y < 0 в четверти {quarter}");
            break;

        default:
            Console.WriteLine($"Такой четверти как {quarter} нет");
            break;
    };
};


Console.Clear();
Console.Write("Введите номер координатной плоскости: ");
int quarter = Convert.ToInt32(Console.ReadLine());

PrintCord(quarter);
PrintCord(new Random().Next(0, 5));




