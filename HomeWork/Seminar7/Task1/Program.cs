/*
Задача 47.
Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
m = 3, n = 4.
0,5 7 -2 -0,2
1 -3,3 8 -9,9
8 7,8 -7,1 9
*/

int GetNumber(string msg)
{
    Console.Write(msg);
    int userNumber = Convert.ToInt32(Console.ReadLine());;
    return userNumber;
}

double[,] InitArray(int m, int n)
{
    double [,] tempArray = new double[m,n];
    Random rnd = new Random();
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            tempArray[i, j] = Math.Round(rnd.Next(0, 100) + rnd.NextDouble(), 2);
        }
    }

    return tempArray;
}

void PrintArray(double [,] tempArray)
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

int m = GetNumber("Введите число строк: ");
int n = GetNumber("Введите число столбцов: ");
double[,] array = InitArray(m, n);
PrintArray(array);

