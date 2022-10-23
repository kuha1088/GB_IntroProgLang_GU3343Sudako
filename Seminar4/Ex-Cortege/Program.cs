//первым возращаем максимальный, вторым минимальный
(int, int) GetMaxAndMinTemp(int [] array)
{
    int max = array[0];
    int min = array[0];

    for (int i = 0; i < array.Length; i++)
    {
        if(min > array[i])
            min = array[i];

        if(max < array[i])
            max = array[i];
    }

    return (max, min);
}

var array = new int[10];
var rnd = new Random();

for (int i = 0; i < array.Length; i++)
{
    array[i] = rnd.Next(1,10);
}


(int max, int min) = GetMaxAndMinTemp(array);

