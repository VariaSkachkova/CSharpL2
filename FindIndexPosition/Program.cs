int [] array = {11,25,31,4,54,66,72,48};
int n = array.Length;
int find = 66;
int index = 0;
while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
    }
    index++;
}

