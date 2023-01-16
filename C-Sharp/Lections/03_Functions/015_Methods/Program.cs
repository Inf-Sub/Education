// Method 1
void Method1(){
    Console.WriteLine("Author: ...");
};

Method1();





// Method 2
void Method2(string msg){
    Console.WriteLine($"{msg}");
};

Method2("Any text");





// Method 2 (возможность указания названия переменной/параметра которой мы присваиваем значение)
void Method2_1(string msg, int count){
    int i = 0;
    while(i++ < count){
        Console.WriteLine($"{msg} #{i}");
    };
};

Method2_1(msg: "Any text", count: 5);





// Method 3
int Method3(){
    return DateTime.Now.Year;
};

int year = Method3();
Console.WriteLine($"{year}");





// Method 4
string Method4(int count, string text){
    int i = 0;
    string result = String.Empty;

    while(i++ < count){
        result += text;
    };
    return result;
};

string text = Method4(10, "z");
Console.WriteLine($"{text}");





// Method 4 + cycle for
string Method4(int count, string text){
    string result = String.Empty;

    //for(int i = 0; i < count; i++){
    for(int i = 0; i++ < count;){
        result += $"{i} - {text}\n";
    };
    return result;
};

string text = Method4(10, "z");
Console.WriteLine($"{text}");



