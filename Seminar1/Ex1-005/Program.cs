// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает последнюю цифру этого числа.
// 	456 -> 6
// 	782 -> 2
// 	918 -> 8

Console.WriteLine("Введите трехзначное число: ");
string UserNumber = Console.ReadLine();
int Number = int.Parse(UserNumber);


if (Number >= 100 && Number <= 999 || Number <= -100 && Number >= -999)
{
    int Result = Math.Abs(Number % 10);
Console.WriteLine($"Последняя цифра этого числа: {Result}");
}
else
{
Console.WriteLine($"Введите другое число, это число не трехзначное");
}  

