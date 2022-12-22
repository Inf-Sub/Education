/*
Итерация 

Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру.
3 -> Среда 
5 -> Пятница
*/

string day;
int number;

void WaitSeconds(double sec)
{
    System.Threading.Thread.Sleep((int)(sec * 1000));
};

Console.Clear();

Console.WriteLine(
    "Задача №3. Напишите программу, которая будет выдавать название дня недели по заданному номеру:\n"+
    "\n"
);
WaitSeconds(1);

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
        WaitSeconds(2);
    };
    // Console.WriteLine($"{number} -> {day}");
}while(day == "");

Console.WriteLine($"{number} -> {day}");
