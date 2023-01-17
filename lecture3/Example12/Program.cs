// Вид5

string Method4(int count, string text)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++)
    {
        result = result + text;
    }
    return result;
}


string res = Method4(10, "z");
//Console.WriteLine(res);


for (int i = 2; i <= 10; i++)
{
    for (int g = 2; g <= 10; g++)
    {
        Console.WriteLine($"{i} * {g} = {i*g}");
    }
    Console.WriteLine();
}
