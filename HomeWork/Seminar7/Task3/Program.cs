/*
Задача 52.
Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
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

void SearchColumnArithmeticMean(int [,] tempArray)
{
    double arithmeticMean = new double();
    double storage = new double();

    for (int j = 0; j < tempArray.GetLength(1); j++)
    {
        for (int i = 0; i < tempArray.GetLength(0); i++)
        {
            storage += tempArray[i, j]; 
        }
        arithmeticMean = Math.Round(storage / tempArray.GetLength(0), 1);
        Console.WriteLine($"Среднее арифмитическое столбца №{j + 1} = {arithmeticMean}");
        storage = 0;
    }
}


int arrayStringNumber = GetNumber("Введите число строк: ");
int arrayColumnNumber = GetNumber("Введите число столбцов: ");
int[,] array = InitArray(arrayStringNumber, arrayColumnNumber);
Console.WriteLine();
Console.WriteLine("Двумерный массив: ");
PrintArray(array);
Console.WriteLine();
SearchColumnArithmeticMean(array);
