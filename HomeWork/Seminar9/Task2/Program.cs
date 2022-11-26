/*
Задача 66:
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

int GetNumber(string msg)
{
    Console.Write(msg);
    int userNumber = Convert.ToInt32(Console.ReadLine());
    return userNumber;
}

int NumbersSum(int count, int number, int total)
{
    if(count > number) return total;
    else
    {
        total += count;
        return NumbersSum(count + 1, number, total);
    }
    
}

int userNumberM = GetNumber("Введите число M: ");
int userNumberN = GetNumber("Введите число N: ");
Console.WriteLine();
int total = NumbersSum(count: userNumberM, number: userNumberN, total: 0);
Console.Write($"Сумма натуральных элементов в промежутке от {userNumberM} до {userNumberN} = {total}");

