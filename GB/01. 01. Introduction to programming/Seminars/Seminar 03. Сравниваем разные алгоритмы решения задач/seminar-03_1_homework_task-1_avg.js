/*
Задача 2. Напишите псевдокод по блок-схеме
Найти среднее арифметическое среди всех элементов массива [2, 5, 13, 7, 6, 4]
*/
// version 1
var numbers = [2, 5, 13, 7, 6, 4];
var size = 6;
var sum = 0;
var avg = 0;
var index = 0;

while(index < size){
	sum += numbers[index++];
};
avg = sum / size;
console.log(avg);

// version 2
var numbers = [2, 5, 13, 7, 6, 4];
var index = size = numbers.length;
var sum = 0;
while(index--){
	sum += numbers[index];
};
console.log(sum / size);