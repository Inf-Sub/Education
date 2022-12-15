Console.Clear();

Console.Write("Введите число: ");
// variation 1
// int a = int.Parse(Console.ReadLine());

// variation 2
int a = Convert.ToInt32(Console.ReadLine());

// print
// Console.WriteLine("Квадрат "+ a +" = "+ (a * a));

// Интерполяция
Console.WriteLine($"Квадрат {a}  = {a * a}");

