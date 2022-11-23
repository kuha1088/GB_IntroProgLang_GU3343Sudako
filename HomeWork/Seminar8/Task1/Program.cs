/*
Задача 54:
Задайте двумерный массив.
Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2
*/

int GetNumber(string msg)
{
    Console.Write(msg);
    int userNumber = Convert.ToInt32(Console.ReadLine());;
    return userNumber;
}

int[,] InitArray(int m, int n)
{
    int [,] tempArray = new int[m,n];
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

int[,] ChangeArray(int[,] array, int m, int n)
{
    int temp = new int();
        
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < (array.GetLength(1) - 1); j++)
        {
            for (int k = j + 1; k < array.GetLength(1); k++)
            {
                if((array[i, j] < array[i, k]))
                {
                    temp = array[i, j];
                    array[i, j] = array[i, k];
                    array[i, k] = temp;
                }
            }
             
        }   
    }

    return array;
}

int stringsNumber = GetNumber("Введите число строк: ");
int columnsNumber = GetNumber("Введите число столбцов: ");
int[,] firstArray = InitArray(stringsNumber, columnsNumber);
PrintArray(firstArray);
Console.WriteLine();
int[,] newArray = ChangeArray(array: firstArray, m: stringsNumber, n: columnsNumber);
PrintArray(newArray);