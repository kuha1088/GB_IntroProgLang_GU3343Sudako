﻿/*
Задача 31: Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.
*/

int[] InitArray()
{
    int[] result = new int[12];
    Random rnd = new Random();
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(-9,10);
    }

    return result;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

//первый элемент - сумма положительных, второй - сумма отрицательных
(int, int) GetPositiveAndNegativeSumm(int[] array)
{
    int positiveSumm = 0;
    int negativeSumm = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if(array[i]>0)
            positiveSumm+= array[i];
        else
            negativeSumm+= array[i];
    }

    return (positiveSumm, negativeSumm);
}

int[] array = InitArray();
PrintArray(array);

(int positiveSumm, int negativeSumm) = GetPositiveAndNegativeSumm(array);

Console.WriteLine($"Сумма положительных: {positiveSumm}, сумма отрицательных: {negativeSumm}");

