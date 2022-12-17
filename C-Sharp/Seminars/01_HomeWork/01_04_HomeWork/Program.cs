/*
Задача 4: Напишите программу, которая принимает на вход три числа и выдает максимальное из этих чисел.

*/

string read, version;
double a, b, c, i, max;
string[] array;
int len;
int count = 3;

while (true)
{
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


    if (version == "1")
    {
        while (true)
        {
            Console.Write("Введите три числа через пробел: ");
            read = Console.ReadLine();
            read = read.Replace(".", ",");
            array = read.Split(' ');
            len = array.Length;

            Console.WriteLine($"{len}");

            if (len != count)
            {
                Console.Write(
                                $"Количество введенных чисел: {len}, по условию задачи - должно быть {count} числа!\n\n" +
                                $"Нажмите ENTER для продолжения или любую клавишу и затем ENTER для выхода из программы "
                );
            };


            max = len - 1;

            while (len-- > 0)
            {
                i = Convert.ToDouble(array[len]);

                if (i > max)
                {
                    max = i;
                };
            };

            Console.Write(
                $"Число {max} максимальное!\n\n" +
                $"Нажмите ENTER для продолжения или любую клавишу и затем ENTER для выхода из программы "
            );


            if (Console.ReadLine() != "")
            {
                break;
            };
        };
    }
    else if (version == "2")
    {
        while (true)
        {
            Console.WriteLine("Введите три числа!");

            Console.Write("Введите первое число: ");
            read = Console.ReadLine();
            read = read.Replace(".", ",");
            a = Convert.ToDouble(read);

            Console.Write("Введите второе число: ");
            read = Console.ReadLine();
            read = read.Replace(".", ",");
            b = Convert.ToDouble(read);

            Console.Write("Введите третье число: ");
            read = Console.ReadLine();
            read = read.Replace(".", ",");
            c = Convert.ToDouble(read);


            // решение без массивов:
            max = a;
            if (b > max)
            {
                max = b;
            }
            else if (c > max)
            {
                max = c;
            };

            Console.Write(
                $"Число {max} максимальное!\n\n" +
                $"Нажмите ENTER для продолжения или любую клавишу и затем ENTER для выхода из программы "
            );
            if (Console.ReadLine() != "")
            {
                break;
            };
        };

    }
    else
    {
        break;
    };
};