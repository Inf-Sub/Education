Console.WriteLine("Введите имя пользователя: ");
string username = Console.ReadLine();
if(username.ToLower() == "маша"){
    Console.WriteLine("Ура, это же "+ username +"!");
}else{
    Console.WriteLine("Привет "+ username);
}