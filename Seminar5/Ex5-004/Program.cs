/*
Задача 35: Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5
*/

int[] InitArray()
{
    int[] result = new int[10];
    Random rnd = new Random();
    for (int i = 0; i < 10; i++)
    {
        result[i] = rnd.Next(-9,100);
    }
    return result;
}
void Print(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

int Result( int[] array)

{
    int num = 0;
        for (int i = 0; i < array.Length; i++)
    {
        if (array[i] <=99 && array[i] >=10)
        {
        num++;
        }
    }
    return num;

}

int[] array = InitArray();
int result = Result(array);
Print(array);
Console.WriteLine($"{result}");
