int[] array = { 43, 69, 28, 19, 69, 66, 11, 24 };
int find = 69;
int n = array.Length;
int index = 0;

while (index < n)
{
    if (find == array[index])
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}


