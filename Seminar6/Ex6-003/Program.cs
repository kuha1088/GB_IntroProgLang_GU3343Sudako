/*
Задача 42: Напишите программу, которая будет преобразовывать десятичное число в двоичное.
45 -> 101101
3  -> 11
2  -> 10
*/

int GetNumber(string msg)
{
    Console.Write(msg);
    int message = Convert.ToInt32(Console.ReadLine());
    return message;
}

string NumberConvert(int userNumber)
/*
Надо делить на 2 пока результат от деления на 2 не будет < 2
*/
{
string result = String.Empty;

    while(userNumber != 0)
    {
    result += userNumber % 2;
    userNumber =  userNumber / 2;
    }

return result;
}

string Revert(string a)
{
string resultA = new string(a.Reverse().ToArray());
return resultA;
}

int numberA = GetNumber("Введите число: ");
string resultOfConvert = NumberConvert(numberA);
string finalResult = Revert(resultOfConvert);
Console.Write($"Преобразованное число: {finalResult}");



