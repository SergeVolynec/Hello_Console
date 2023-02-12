void FillArray(int[] collection)
{
    int n = collection.Length;
    int index = 0;
    while (index < n)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int IndexOf (int[] collection, int find)
{
    int size = collection.Length;
    int index = 0;
    int position = -1;
    while (index<size)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        index++;
    } 
    return position;
}

int[] array = new int[10];

FillArray(array);
PrintArray(array);
Console.WriteLine();
int pos = IndexOf (array, 44);
Console.WriteLine(pos);