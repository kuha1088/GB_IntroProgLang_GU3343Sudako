/*
Задача 56:
Задайте прямоугольный двумерный массив.
Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

(int, int) GetValues()
{
    (int, int) result = (0, 0);
    
    while(true)
    {
        Console.Write("Введите число строк: ");
        int stringsNumber = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число столбцов: ");
        int columnsNumber = Convert.ToInt32(Console.ReadLine());
        result = (stringsNumber, columnsNumber);
        if(CheckArray(a: stringsNumber, b: columnsNumber) == true) break; 
    }   

    return result;
}

bool CheckArray(int a, int b)
{
    if(a != b)
    {
        return true;
    }
    else
    {
        Console.WriteLine("Параметры массива не удовлетворяют требованиям задачи\n");
        return false;
    }
}

int[,] InitArray(int a, int b)
{
    int [,] tempArray = new int[a,b];
    Random rnd = new Random();
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            tempArray[i, j] = rnd.Next(0, 10);
        }
    }

    return tempArray;
}

void PrintMultivariateArray(int [,] tempArray)
{
    Console.WriteLine("Массив: ");
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            Console.Write($"{tempArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

void PrintUnivariateArray(int [] tempArray)
{
    Console.WriteLine($"Суммы элементов строк массива: {string.Join(", ", tempArray)}");
}

int[] StringsValue(int [,] tempArray)
{
    int[] result = new int[tempArray.GetLength(0)];
    int stringSum = new int();

    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            stringSum += tempArray[i, j]; 
        }
        result[i] = stringSum;
        stringSum = 0;
    }

    return result;
}

void MinStringNumber(int[] tempArray)
{
    int result = new int();
    int min = tempArray.Min();
    for (int i = 0; i < tempArray.Length; i++)
    {
        if(tempArray[i] == min) result = i + 1;
    }

    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {result}");
}

(int, int) arrayParametrs = GetValues();
int[,] array = InitArray(a: arrayParametrs.Item1, b: arrayParametrs.Item2);
Console.WriteLine();
PrintMultivariateArray(tempArray: array);
Console.WriteLine();
int[] stringsValue = StringsValue(tempArray: array);
PrintUnivariateArray(tempArray: stringsValue);
MinStringNumber(tempArray: stringsValue);
