//1.Ввод элементов массива
// 1) Считать int число
// int <- string
// 2. Создать массив
// 1) int чисел 
// int[] <- int 
// 3. Заполнить массив с клавиатуры
// int[] <- (void)
// Найти произведение пар
// int[] <- int[]
// Распечатать в новый массив
// string <- int[]

Console.Clear();
Console.WriteLine();

int size = new Random().Next(10, 26);
int min = 1;
int max = 100;
Console.WriteLine($"Количество элементов исходного массива: {size}");

int[] FillArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max + 1);
    }
    return array;
}

// Cобираем новый массив из произведений пар.
// В случае, если количество элементов исходного массива нечетное, 
//центральное знаяение не учитывается

int[] GetSolution(int[] data)
{
    int[] product = new int[data.Length / 2];
    int last = data.Length - 1;
    for (int i = 0; i < data.Length / 2; i++)
    {
        product[i] = data[i] * data[last];
        last = last - 1;
    }
    return product;
}

void PrintArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write(arr[i] + " ");
    }
    Console.WriteLine();
}

int[] array = FillArray(size, min, max);
PrintArray(array);

Console.WriteLine();
Console.WriteLine("Новый массив: ");
PrintArray(GetSolution(array));





//for(i <= N/2)

//number = a[i] * a[N - 1 - i]

//res[N/2]
//res[i] = a[i] * a[N - 1 - i];

