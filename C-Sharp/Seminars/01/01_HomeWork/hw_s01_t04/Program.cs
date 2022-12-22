/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

*/

string? version;
double a, b, c, i, max;
string[]? array;
int len;
int count = 3;
char[] charsToTrim = {' '};


double ReadDoubleFromString(string write){
    Console.Write($"{write}");
    string? text = Console.ReadLine()?.Trim(charsToTrim).Replace(".", ",");

    return Convert.ToDouble(text);
};

bool ExitFromProg(){
    bool result;
    Console.Write(
        $"Нажмите ENTER для продолжения или любую клавишу и затем ENTER для выхода из программы "
    );

    result = (Console.ReadLine() != "") ? true : false;
    Console.WriteLine();

    return result;
};

double MaxNumbers(double num1, double num2){
    return (num2 > num1) ? num2 : num1;
};


while (true){
    Console.Clear();

    Console.WriteLine(
        "Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.\n"
    );

    Console.Write(
        "Выберите вариант ввода чисел:\n" +
        "Введите 1, для ввода цифр в одну строку, через пробел\n" +
        "Введите 2, для ввода каждого числа отдельно\n" +
        "Введите любое другое значение, для выхода из программы: "
    );
    version = Console.ReadLine();
    Console.WriteLine();

    if(version != "1" && version != "2"){
        break;
    };

    while (true){
        if (version == "1"){
            Console.Write("Введите три числа через пробел: ");

            array = Console.ReadLine()?.Trim(charsToTrim).Replace(".", ",").Split(' ');
            len = array.Length;
            //Console.WriteLine($"{len}");

            if (len == count){
                max = len - 1;

                while (len-- > 0){
                    i = Convert.ToDouble(array[len]);
                    if (i > max) max = i;
                };

                Console.WriteLine($"Число {max} максимальное!\n");
            }else{
                Console.WriteLine($"Количество введенных чисел: {len}, по условию задачи - должно быть {count} числа!\n\n");
            };
        }else if (version == "2"){
            Console.WriteLine("Введите три числа!");

            a = ReadDoubleFromString("Введите первое число: ");
            b = ReadDoubleFromString("Введите второе число: ");
            c = ReadDoubleFromString("Введите третье число: ");

            // решение без массивов:
            max = MaxNumbers(MaxNumbers(a, b), c);
            
            Console.WriteLine($"Число {max} максимальное!\n");
        }else{
            break;
        };
         

        if (ExitFromProg())
        {
            break;
        };
    };
};
