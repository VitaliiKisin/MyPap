int[] array = {11, 56,67, 87, 45, 67, 78, 90, 34};

int n = array.Length;
int find = 67;

int index = 0;

while (index < n)
{

    if(array[index] == find)
    {
    Console.WriteLine(index);
    break;
    }
//index = index + 1;
index++;
}