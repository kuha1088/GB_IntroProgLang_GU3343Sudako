/*
Напишите программу, которая выводит случайное число из отрезка [10, 99] и показывает наибольшую цифру числа.
78 -> 8
12 ->2
85 ->8
*/

Random rnd = new Random();
int Number = rnd.Next(10, 100);

int FirstDigit = Number / 10;
int SecondDigit = Number % 10;

if(FirstDigit > SecondDigit)
    Console.WriteLine($"Наибольшая цифра числа {Number} = {FirstDigit}");
else if (SecondDigit > FirstDigit)
    Console.WriteLine($"Наибольшая цифра числа {Number} = {SecondDigit}");
else
    Console.WriteLine($"Числа равны");