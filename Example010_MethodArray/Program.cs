int[] array = {12, 23, 54, 95, 17, 25, 89, 95, 64};

int n = array.Length;
int find = 95;

int index = 0;

while (index < n)
{
    if(array[index] == find)
    {
        Console.WriteLine(index);
        break;
    }
    index++;
}
