/*

Задача 24: Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
7 -> 28
4 -> 10
8 -> 36

*/

Console.WriteLine("Введите число А:");
int number = int.Parse(Console.ReadLine());
int summ = 0;

for (int i = 1; i <= number; i++)
{   
    summ += i; // summ = summ + i; +=, -=, *=, /=
}

Console.WriteLine($"Сумма чисел от 1 до {number} = {summ}");
