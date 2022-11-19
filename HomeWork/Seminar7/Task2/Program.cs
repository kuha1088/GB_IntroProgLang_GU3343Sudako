/*
Задача 50.
Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента
или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет
*/

int GetNumber(string msg)
{
    Console.Write(msg);
    int userNumber = Convert.ToInt32(Console.ReadLine());;
    return userNumber;
}

int[,] InitArray(int m, int n)
{
    int [,] tempArray = new int[m, n];
    Random rnd = new Random();
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            tempArray[i, j] = rnd.Next(0, 100);
        }
    }

    return tempArray;
}

void PrintArray(int [,] tempArray)
{
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            Console.Write($"{tempArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

void SearchElement(int [,] tempArray, int m, int n)
{
    if(
    m < tempArray.GetLength(0)
    && m >= 0
    && n < tempArray.GetLength(1)
    && n >= 0
    )
    {
        Console.WriteLine($"Значение искомого элемента = {tempArray[m, n]}");
    }
    else
    {
        Console.WriteLine($"Такой элемент в массиве отсутствует");
    }
}

int arrayStringNumber = GetNumber("Введите число строк: ");
int arrayColumnNumber = GetNumber("Введите число столбцов: ");
int[,] array = InitArray(arrayStringNumber, arrayColumnNumber);
Console.WriteLine();
Console.WriteLine("Двумерный массив: ");
PrintArray(array);
Console.WriteLine();
int userSearchStringNumber = GetNumber("Введите номер строки искомого элемента: ");
int userSearchColumnNumber = GetNumber("Введите номер столбца искомого элемента: ");
SearchElement(array, userSearchStringNumber, userSearchColumnNumber);