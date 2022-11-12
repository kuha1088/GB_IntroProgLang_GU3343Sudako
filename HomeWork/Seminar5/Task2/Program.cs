/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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
        result[i] = rnd.Next(0, 100);
    }

    return result;
}

int EvenElementsSum(int[] col)
{
    int result = 0;

    for (int i = 0; i < col.Length; i++)
    {
    if (i%2 != 0)
    result += col[i];
    }

    return result;
}

void PrintArray(int[] col)
{
    Console.WriteLine(string.Join(", ", col));
}

void PrintResult(int r)
{
    Console.WriteLine($"Cумма элементов, стоящих на нечётных позициях в массиве: {r}");
}


int ArrLenght = Get("Введите число элементов массива: ");
int[] arr = InitArray(ArrLenght);
PrintArray(arr);
int result = EvenElementsSum(arr);
PrintResult(result);
