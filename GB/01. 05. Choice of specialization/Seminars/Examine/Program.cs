
Run();


void Run(){
    string rn = "\n";
    string title =  $"";
        

    ViewTitleTask(title);
    Console.Clear();
    Console.WriteLine(); 
};




// ViewTitleTask version 2.1
void ViewTitleTask(string? text = ""){
    string rn = "\n";
    Console.Clear();
    Console.WriteLine(
        $"{text}{rn}"+
        $"Для завершения программы, нажмите Ctrl + C{rn}{rn}"+
        $"Press any key to continue..."
    );
    Console.ReadKey();
    Console.Clear();
};