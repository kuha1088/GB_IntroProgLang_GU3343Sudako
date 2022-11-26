/*
Задача 68:
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int GetNumber(string msg)
{
    Console.Write(msg);
    while(true)
    {
        if(int.TryParse(Console.ReadLine(), out var userNumber))
        if(userNumber >= 0)
        return userNumber;
        else
        Console.WriteLine("Введенное значение не удовлетворяет требованиям задачи\n");
    }
}

int Akk(int m, int n)
{
    if(m == 0) return n + 1;
    else if ((m > 0) && (n == 0)) return Akk(m - 1, 1);
    else if ((m > 0) && (n > 0)) return Akk(m - 1, Akk(m, n - 1));
    else return n + 1;
}

int userNumberM = GetNumber("Введите число M: ");
int userNumberN = GetNumber("Введите число N: ");
Console.WriteLine();
int result = Akk(m: userNumberM, n: userNumberN);
Console.Write($"Функция Аккермана для {userNumberM} и {userNumberN} = {result}");
