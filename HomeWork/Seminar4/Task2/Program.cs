/*Задача 27
Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12
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

int Amount(int check)
{
    int result = 0;
    int amount = 0;
    string checkStr = check.ToString();
    int lenght = checkStr.Length;
    for(int i = 1; i <= lenght; i++)
    {
    amount = check % 10;
    check = check / 10;
    result = result + amount;
    }
    return result;
}

int number = Get("Введите число: ");
int numberAm = Amount(number);
Console.WriteLine($"Сумма чифр числа {number} = {numberAm}");