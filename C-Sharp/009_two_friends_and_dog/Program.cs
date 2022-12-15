int count = 0;
double distance = 10000;
double first_friend_speed = 1; 
double second_friend_speed = 2; 
double dog_speed = 5;
int friend = 2;
double time = 0;

while(distance > 10){
    if(friend == 1){
        time = distance / (first_friend_speed + dog_speed);
        friend = 2;
    }else{
        time = distance / (second_friend_speed + dog_speed);
        friend = 1;
    };
    distance = distance - (first_friend_speed + second_friend_speed) * time;
    count++;    
    /*
    Console.WriteLine("count: "+ count);
    Console.WriteLine("distance: "+ distance);
    Console.WriteLine("time: "+ time);
    Console.WriteLine("");
    */
};
Console.WriteLine(count);
