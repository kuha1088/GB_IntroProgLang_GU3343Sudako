/*Задача 19
Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
14212 -> нет
12821 -> да
23432 -> да
*/

int Get(string message)
{
    Console.WriteLine(message);
    while(true)
    {
        if(int.TryParse(Console.ReadLine(), out var userNumber) && Math.Abs(userNumber) > 9999 && Math.Abs(userNumber) < 100000)
        return userNumber;
        else
        Console.WriteLine("Это не число, либо число не удовлетворяет требованиям задачи\n");
    }
}

void PolyCheck(int testVar)
{
    int result = 0;
    string strTestVar = testVar.ToString();
    int lenght = strTestVar.Length;
    int final = strTestVar.Length / 2;
    for (int i = 0; i < final; i++)
    {
        int j = lenght - i - 1;
        int x = Convert.ToInt32(strTestVar[i]);
        int y = Convert.ToInt32(strTestVar[j]);
        if(x == y)
        result = 0;
        else
        result = 1;
    }
    
    if(result == 0)
    Console.WriteLine("Да, это полиндром");
    else
    Console.WriteLine("Нет, это не полиндром");
}

//Получение числа и проверка на соответствие условиям задачи.
int number = Get("Введите число: ");
//Тест на полиндромность
PolyCheck(number);

