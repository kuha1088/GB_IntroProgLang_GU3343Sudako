/*
Задача 40: Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.
Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.
*/

int GetNumber(string msg)
{
    Console.Write(msg);
    int message = Convert.ToInt32(Console.ReadLine());
    return message;
}

void Check(int a, int b, int c)
{
    if(a < (b + c) && b < (a + c) && c<(a + b))
    Console.WriteLine("Такой треугольник существует");
    else 
    Console.WriteLine("Такой треугольник НЕ существует");
}


int numberA = GetNumber("Введите первое число:");
int numberB = GetNumber("Введите второе число:");
int numberC = GetNumber("Введите третье число:");

Check(numberA, numberB, numberC);

