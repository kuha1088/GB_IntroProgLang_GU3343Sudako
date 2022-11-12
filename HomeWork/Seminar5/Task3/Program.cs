/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76
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

double[] InitArray(int UserNumber)
{
    Random rnd = new Random();
    double[] result = new double[UserNumber];
    
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = Math.Round(rnd.Next(0, 100) + rnd.NextDouble(), 2);
    }

    return result;
}

double MaxElement(double[] col)
{
    double result = col[0];

    for (int i = 1; i < col.Length; i++)
    {
    if (col[i] > result)
    result = col[i];
    }

    return result;
}

double MinElement(double[] col)
{
    double result = col[0];

    for (int i = 1; i < col.Length; i++)
    {
    if (col[i] < result)
    result = col[i];
    }

    return result;
}

double MaxMinElementsDiff(double a, double b)
{
    double result = a - b;
    return result;
}

void PrintArray(double[] col)
{
    Console.WriteLine(string.Join(", ", col));
}

void PrintResult(double r, double maxColEl, double minColEl)
{
    Console.WriteLine($"Максимальный элемент массива: {maxColEl}. Минимальный элемент массива: {minColEl}. Разница между максимальным и минимальным элементами массива: {r}");
}


int ArrLenght = Get("Введите число элементов массива: ");
double[] arr = InitArray(ArrLenght);
InitArray(ArrLenght);
PrintArray(arr);
double maxEl = MaxElement(arr);
double minEl = MinElement(arr);
double result = MaxMinElementsDiff(maxEl, minEl);
PrintResult(result, maxEl, minEl);
