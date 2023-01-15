Console.Clear();
Console.WriteLine("Введи цифру, обозначающую день недели  ");

int dayNumber = Convert.ToInt32(Console.ReadLine());

////void DayOfTheWeek(int dayNumber);

if (dayNumber == 6 || dayNumber == 7)
{
    Console.WriteLine("Выходной ");
}
else 
if (dayNumber < 1 || dayNumber > 7) 
{
    Console.WriteLine("Введите цифру от 1 до 7 ");
}
 else Console.WriteLine("Будний день ");

{
///DayOfTheWeek(dayNumber);
}

