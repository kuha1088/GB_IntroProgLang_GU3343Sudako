void FillArray(int[] Collection)
{
   int lenght = Collection.Length;
   int Index = 0;
   while (Index < lenght)
   {
       Collection[Index] = new Random().Next(1, 10);
       Index++;
   }
}

void PrintArray(int[] Col)
{
   int Count = Col.Length;
   int Position = 0;
   while (Position < Count)
   {
        Console.WriteLine(Col[Position]);
        Position++;
   }
}


int IndexOf(int[] Collection, int Find)
{
    int Count = Collection.Length;
    int Index = 0;
    int Position = -1;
    while(Index < Count)
    {
        if(Collection[Index] == Find)
        {
          Position = Index;
          break;
        }
        Index++;
    }
    return Position;
}

int[] array = new int[10];

FillArray(array);
array[4] = 4;
array[6] = 6;
PrintArray(array);
Console.WriteLine();

int Pos = IndexOf(array, 4444);
Console.WriteLine(Pos);
