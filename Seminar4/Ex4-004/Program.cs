/* Задача 30: Напишите программу, 
которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
[1,0,1,1,0,1,0,0]
*/

void FillArray(int[] collection) // заполняет массив цифрами 
{
    int lenght = collection.Length; // определяет размер массива
    int index = 0; //ячейка с которой он будет работать
    while (index < lenght)
    {
       collection[index] = new Random().Next(0, 2);
       index++; 
    }
}

void PrintArray(int[] col) // выдает цифры массива, что бы я увидел
{
    int count = col.Length;
    int position = 0;
    while(position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}
int [] array = new int [8];
FillArray(array);
PrintArray(array);
