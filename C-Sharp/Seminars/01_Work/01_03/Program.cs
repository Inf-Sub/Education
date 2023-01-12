/*
Итерация 

Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда 
5 -> Пятница
*/

string day;
int number;

Console.Clear();

Console.WriteLine(
    "Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру:\n"+
    "\n"
);
System.Threading.Thread.Sleep(1000);

do{
    Console.Clear();
    Console.WriteLine(
        "Введите номер дня недели:"
    );
    number = Convert.ToInt32(Console.ReadLine());
    
    if(number == 1){
        day = "Понедельник / Monday";
    }else if(number == 2){
        day = "Вторник / Tuesday";
    }else if(number == 3){
        day = "Среда / Wednesday";
    }else if(number == 4){
        day = "Четверг / Thursday";
    }else if(number == 5){
        day = "Пятница / Friday";
    }else if(number == 6){
        day = "Суббота / Saturday";
    }else if(number == 7){
        day = "Воскресенье / Sunday";
    }else{
        day = "";
        Console.WriteLine($"Дня недели с номером {number} не существует, попробуйте еще раз!\n");
        System.Threading.Thread.Sleep(2000);
    };
    // Console.WriteLine($"{number} -> {day}");
}while(day == "");

Console.WriteLine($"{number} -> {day}");
