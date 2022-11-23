/*
Задача 62:
Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07
*/

(int, int) GetValues()
{
    (int, int) result = (0, 0);
    
    while(true)
    {
        Console.Write("Введите число строк: ");
        int userNumber1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите число столбцов: ");
        int userNumber2 = Convert.ToInt32(Console.ReadLine());

        result = (userNumber1, userNumber2);
        if(CheckArray(a: userNumber1, b: userNumber2) == true) break; 
    }   

    return result;
}

bool CheckArray(int a, int b)
{
    if(a == 4 && b == 4)
    {
        return true;
    }
    else
    {
        Console.WriteLine("Параметры массива не удовлетворяют требованиям задачи (4 x 4)\n");
        return false;
    }
}

int IterationNumber(int number)
{
    int result = new int();
    result = number + 1;
    return result;
}

int[,] InitArray(int strings, int columns)
{
    int[,] result = new int[strings, columns];
    return result;
}

void FirstFillArray(int [,] tempArray, int startElement, int iterationNumber)
{
    int edgeLenght = tempArray.GetLength(0) - iterationNumber; // Для счетчика циклов нужно отнять от длины ребра "1"

    for (int j = 0; j < edgeLenght; j++)
    {
        tempArray[0, j] = startElement + 1;
        startElement = tempArray[0, j];
    }

    for (int i = 0; i < edgeLenght; i++)
    {
        tempArray[i, edgeLenght] = startElement + 1;
        startElement = tempArray[i, edgeLenght];
    }
        
    for (int j = edgeLenght; j > 0; j--)
    {
        tempArray[edgeLenght, j] = startElement + 1;
        startElement = tempArray[edgeLenght, j];
    }
        
    for (int i = edgeLenght; i > 0; i--)
    {
        tempArray[i, 0] = startElement + 1;
        startElement = tempArray[i, 0];
    }

    edgeLenght --;           
}

void NextFillArray(int [,] tempArray, int iterationNumber)
{
    int edgeLenght = tempArray.GetLength(0) - iterationNumber; // Для счетчика циклов нужно отнять от длины ребра "1"
    int startElement = (edgeLenght + 1) * 4;

    for (int j = (iterationNumber - 1); j < edgeLenght; j++)
    {
        tempArray[(iterationNumber - 1), j] = startElement + 1;
        startElement = tempArray[(iterationNumber - 1), j];
    }

    for (int i = (iterationNumber - 1); i < edgeLenght; i++)
    {
        tempArray[i, edgeLenght] = startElement + 1;
        startElement = tempArray[i, edgeLenght];
    }
        
    for (int j = edgeLenght; j > (iterationNumber - 1); j--)
    {
        tempArray[edgeLenght, j] = startElement + 1;
        startElement = tempArray[edgeLenght, j];
    }
        
    for (int i = edgeLenght; i > (iterationNumber - 1); i--)
    {
        tempArray[i, (iterationNumber - 1)] = startElement + 1;
        startElement = tempArray[i, (iterationNumber - 1)];
    }

    edgeLenght --;           
}

void PrintMultivariateArray(int [,] tempArray)
{
    Console.WriteLine($"Массив: ");
    
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            if (tempArray[i,j] < 10)
            Console.Write($"0{tempArray[i,j]} ");
            else
            Console.Write($"{tempArray[i,j]} ");
        }
        Console.WriteLine();
    }
}

(int, int) arrayParameters = GetValues();
Console.WriteLine();
int iterationNumber = 0;
int[,] array = InitArray(strings: arrayParameters.Item1, columns: arrayParameters.Item2);
iterationNumber = IterationNumber(number: iterationNumber);
FirstFillArray(tempArray: array, startElement: 0, iterationNumber);
iterationNumber = IterationNumber(number: iterationNumber);
NextFillArray(tempArray: array, iterationNumber);
PrintMultivariateArray(tempArray: array);