/*
Задача 65:
Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5 -> "1, 2, 3, 4, 5"
M = 4; N = 8 -> "4, 6, 7, 8"
*/

int GetNumber(string msg)
{
    Console.WriteLine(msg);
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}

void PrintNimbers(int number, int count)
{
    if(count<=number)
    {
    Console.Write($"{count} ");
    PrintNimbers(number, count+1);
    }
}

int userNumberM = GetNumber("Введите число M:");
int userNumberN = GetNumber("Введите число N:");
PrintNimbers(userNumberN,userNumberM);
