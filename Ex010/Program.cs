int [] array = {1, 12, 31, 4, 18, 15, 16, 17, 18};

int n = array.Length;
int Find = 18;

int Index = 0;

while (Index < n)
{
    if(array[Index] == Find)
    {
        Console.WriteLine(Index);
        break;
    }
    
    //index = index = index + 1
    Index++;
}

