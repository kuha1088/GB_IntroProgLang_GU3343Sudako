/*
Задача 60:
Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

(int, int, int) GetValues()
{
    (int, int, int) result = (0, 0, 0);
    
    while(true)
    {
        Console.Write("Введите лимит X: ");
        int userNumber1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите лимит Y: ");
        int userNumber2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите лимит Z: ");
        int userNumber3 = Convert.ToInt32(Console.ReadLine());

        result = (userNumber1, userNumber2, userNumber3);
        if(CheckArray(a: userNumber1, b: userNumber2, c: userNumber3) == true) break; 
    }   

    return result;
}

bool CheckArray(int a, int b, int c)
{
    if(a == 2 && b == 2 && c == 2)
    {
        return true;
    }
    else
    {
        Console.WriteLine("Параметры массива не удовлетворяют требованиям задачи (2 x 2 x 2)\n");
        return false;
    }
}

int[,,] InitArray(int arrayLimitX, int arrayLimitY, int arrayLimitZ)
{
    int [,,] tempArray = new int[arrayLimitX, arrayLimitY, arrayLimitZ];
    Random rnd = new Random();
    for (int i = 0; i < tempArray.GetLength(0); i++)
    {
        for (int j = 0; j < tempArray.GetLength(1); j++)
        {
            for (int k = 0; k < tempArray.GetLength(2); k++)
            {
                tempArray[i, j, k] = rnd.Next(10, 100); // для проверки на повторы установить диапазон (10, 20)
                while(TestArrayElementForRepeat(testedArray: tempArray, testedArrayElement: tempArray[i, j, k]) == true)
                {
                    tempArray[i, j, k] = rnd.Next(10, 100); // для проверки на повторы установить диапазон (10, 20)
                }
            }
        }
    }
    // Для проверки на повторы поставить число за пределами числа из диапазона rnd на строках (55,46), (58,50)
    tempArray[0, 0, 0] = 65;
    return tempArray;
}

bool TestArrayElementForRepeat(int [,,] testedArray, int testedArrayElement)
{
    bool result = new bool();
    int count = new int();
    
    for (int i = 0; i < testedArray.GetLength(0); i++)
        {
            for (int j = 0; j < testedArray.GetLength(1); j++)
            {
                for (int k = 0; k < testedArray.GetLength(2); k++)
                {
                    if (testedArray[i,j,k] == testedArrayElement)
                    {
                        count = count + 1;
                    }
                }
            }
        }
    
    if(count > 1)
    result = true;
    else
    result = false;

    return result;
}

void PrintMultivariateArray(int [,,] tempArray)
{
    Console.WriteLine($"Массив: ");
    
    for (int k = 0; k < tempArray.GetLength(2); k++)
    {
        for (int i = 0; i < tempArray.GetLength(0); i++)
        {
            for (int j = 0; j < tempArray.GetLength(1); j++)
            {
                Console.Write($"{tempArray[i,j,k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();  
        }
    }
}

(int, int, int) arrayParameters = GetValues();
Console.WriteLine();
int[,,] array = InitArray(arrayLimitX: arrayParameters.Item1, arrayLimitY: arrayParameters.Item2, arrayLimitZ: arrayParameters.Item3);
PrintMultivariateArray(tempArray: array);




