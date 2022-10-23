/* Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
456 -> 3
78 -> 2
89126 -> 5
*/

Console.WriteLine("Ввведите число: ");

int number = int.Parse(Console.ReadLine());
int count = 0;

while(number != 0)
{
    number = number / 10;
    count++;
}

Console.WriteLine($"Кол-во чисел {count}");
