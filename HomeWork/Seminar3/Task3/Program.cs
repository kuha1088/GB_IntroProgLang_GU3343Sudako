/*Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/

int Get(string msg)
{
    Console.WriteLine(msg);
    while(true)
    {
        if(int.TryParse(Console.ReadLine(), out var userNumber))
        return userNumber;
        else
        Console.WriteLine("Введенное значение не удовлетворяет требованиям задачи\n");
    }
}

void Cube(int n)
{
    for(int i = 1; i <= n; i++)
    {
        if(i!=n)
        Console.Write($"{i*i*i}, ");
        else
        Console.Write($"{i*i*i} ");
    }
}

int number = Get("Введите число: ");
Cube(number);