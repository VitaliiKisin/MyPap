Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[m, n];
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        array [i, j] = Convert.ToInt32(new Random().Next(0,21));  
}
 
for (int i = 0; i < array.GetLength(0); i++) 
{
    for (int j = 0; j < array.GetLength(1); j++)
        Console.Write(array[i,j] + "\t  ");
        Console.WriteLine();
}
 
 Console.Write("Введите координаты y: ");
 int x = Convert.ToInt32(Console.ReadLine());
 Console.Write("Введите координаты x: ");
 int y = Convert.ToInt32(Console.ReadLine());
 
 if (y>m && x>n)
 Console.WriteLine("Такого числа нет!");
 else
 {
 object z = array.GetValue(y,x);
 Console.WriteLine(z);
 }
// Отсчет y и x начинается с нуля.