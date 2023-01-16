// Method 4 + cycle for
string Method4(int count, string text){
    string result = String.Empty;

    //for(int i = 0; i < count; i++){
    for(int i = 0; i++ < count;){
        result += $"{i} - {text}\n";
    };
    return result;
};

string z10 = Method4(10, "z");
// Console.WriteLine($"{z10}");



// таблица умножения
void MultiplicationTable(){
    for(int i = 2; i <= 10; i++){
        for(int j = 2; j <= 10; j++){
            Console.WriteLine($"{i} x {j} = {i * j}");
        };
        Console.WriteLine();
    };
};
//MultiplicationTable();



// === Работа с текстом
// Дан текст. Нужно в тексте заменить все пробелы вертикальной чертой,
// маленькие буквы "к" заменить на большие "К",
// а большие "с" заменить маленькими "С"

string myText = 
    "– Я думаю, – сказал князь, улыбаясь, – что, " +
    "ежели бы вас послали вместо нашего милого Винценгероде, " +
    "вы бы взяли приступом согласие прусского короля. " +
    "Вы так красноречивы. Вы дадите мне чаю?";


string Replace(string text, char oldChar, char newChar){
    string result = String.Empty;
    int length = text.Length;

    for(int i = 0; i < length; i++){
        if(text[i] == oldChar){
            result += newChar;
        }else{
            result += text[i];
        };
    };

    return result;
};

Console.WriteLine(myText);
myText = Replace(myText, ' ', '|');
Console.WriteLine(myText);
myText = Replace(myText, 'к', 'К');
Console.WriteLine(myText);
myText = Replace(myText, 'с', 'С');
Console.WriteLine(myText);