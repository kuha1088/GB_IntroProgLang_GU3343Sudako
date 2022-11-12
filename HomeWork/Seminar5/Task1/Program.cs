/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
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

int[] InitArray(int UserNumber)
{
    Random rnd = new Random();
    int lenght = UserNumber;
    int[] result = new int[lenght];
    
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(100, 1000);
    }

    return result;
}

int EvenSum(int[] col)
{
    int count = 0;
    for (int i = 0; i < col.Length; i++)
    {
    if (col[i]%2 == 0)
        {
        count++;
        }
    }
    return count;
}

void PrintArray(int[] col)
{
    Console.WriteLine(string.Join(", ", col));
}

void PrintResult(int r)
{
    Console.WriteLine($"Количество чётных чисел в массиве: {r}");
}


int ArrLenght = Get("Введите число элементов массива: ");
int[] arr = InitArray(ArrLenght);
InitArray(ArrLenght);
PrintArray(arr);
int result = EvenSum(arr);
PrintResult(result);