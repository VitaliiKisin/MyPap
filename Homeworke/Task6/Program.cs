Console.Clear();
Console.WriteLine("Введи трёхзначное число: ");

int IndexNumber = Convert.ToInt32(Console.ReadLine());
string Number = Convert.ToString(IndexNumber);

if (IndexNumber > 99)
{
    Console.WriteLine(Number[2]);
}

else 

{
    Console.WriteLine("Третьей цифры нет ");
}